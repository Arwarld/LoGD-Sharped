using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Mime;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace LoGD.Server
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseRouting();
            app.UseSession();
            GameMaster g = new GameMaster();

            app.UseEndpoints(endpoints =>
            {
                foreach (string templateCSS in GameMaster.TemplateCSS.Keys)
                {
                    endpoints.MapGet("templates/" + templateCSS + ".css", async context =>
                     {
                         await context.Response.WriteAsync(GameMaster.TemplateCSS[templateCSS].Css);
                     });
                }
                endpoints.Map("{location}.{params}", async context =>
                {
                    string location = context.Request.RouteValues["location"].ToString();
                    string parameters = context.Request.RouteValues["params"].ToString();
                    if (!parameters.Contains(".") && !location.Contains(".") && parameters != "" && parameters.Length > 4 && parameters.Substring(0, 4) == "php?")
                    {
                        parameters = parameters.Substring(4);
                        Dictionary<string, string> getParams = new Dictionary<string, string>();
                        foreach (string pair in context.Request.RouteValues["params"].ToString().Split('&'))
                        {
                            string[] values = pair.Split('=');
                            if (values.Length == 2)
                                getParams.Add(values[0], values[1]);
                            else if (values.Length == 1)
                                getParams.Add(values[0], null);
                        }
                        await context.Response.WriteAsync(g.BuildPage(context, location, new ReadOnlyDictionary<string, string>(getParams)));
                    }
                    else if (!location.Contains(".") && (parameters == "php" || parameters == "php?"))
                        await context.Response.WriteAsync(g.BuildPage(context, location));
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
