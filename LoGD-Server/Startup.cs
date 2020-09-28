#region

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;

#endregion

namespace LoGD.Server
{
    public sealed class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();
            app.UseRouting();
            app.UseSession();
            ProcessModule processModule = Process.GetCurrentProcess().MainModule;
            if (processModule != null)
            {
                app.UseStaticFiles(new StaticFileOptions
                {
                    FileProvider =
                        new PhysicalFileProvider(
                            processModule.FileName.Replace("LoGD-Server.exe", "") +
                            "Game/Images"),
                    RequestPath = new PathString("/images")
                });
                app.UseStaticFiles(new StaticFileOptions
                {
                    FileProvider =
                        new PhysicalFileProvider(
                            processModule.FileName.Replace("LoGD-Server.exe", "") +
                            "Game/Templates/Files"),
                    RequestPath = new PathString("/templates")
                });
            }

            var g = new GameMaster(_configuration.GetValue<string>("host"), _configuration.GetValue<string>("port"),
                _configuration.GetValue<string>("user"), _configuration.GetValue<string>("password"),
                _configuration.GetValue<string>("database"), _configuration.GetValue<string>("prefix"));
            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("{location}.{params}", async context =>
                {
                    string location = context.Request.RouteValues["location"].ToString();
                    string parameters = context.Request.RouteValues["params"].ToString();
                    if (location != null && parameters?.Contains(".") == false && !location.Contains(".") &&
                        parameters != "" && parameters.Length > 4 && parameters.Substring(0, 4) == "php?")
                    {
                        parameters = parameters.Substring(4);
                        Dictionary<string, string> getParams = new Dictionary<string, string>();
                        foreach (string[] values in parameters.Split('&').Select(pair => pair.Split('=')))
                            if (values.Length == 2)
                                getParams.Add(values[0], values[1]);
                            else if (values.Length == 1)
                                getParams.Add(values[0], null);

                        await context.Response.WriteAsync(g.BuildPage(context, location,
                            new ReadOnlyDictionary<string, string>(getParams)));
                    }
                    else if (location?.Contains(".") == false && (parameters == "php" || parameters == "php?"))
                    {
                        await context.Response.WriteAsync(g.BuildPage(context, location));
                    }
                    else
                    {
                        context.Response.StatusCode = 302;
                        context.Response.Headers.Add("Location", "/home.php");
                    }
                });
                endpoints.Map("/", async context =>
                {
                    context.Response.StatusCode = 302;
                    context.Response.Headers.Add("Location", "/home.php");
                });
            });
        }
    }
}
