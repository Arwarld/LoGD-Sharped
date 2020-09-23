using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LoGD.Game.Templates;
using LoGD.Game;
using System.Collections.ObjectModel;

namespace LoGD
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddMvc();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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
                    endpoints.MapGet("templates/"+ templateCSS + ".css", async context =>
                    {
                        await context.Response.WriteAsync(GameMaster.TemplateCSS[templateCSS]);
                    });
                }
                endpoints.MapGet("{location?}", async context =>
                {
                    string location = "home";
                    if (context.Request.RouteValues.ContainsKey("location"))
                        location = context.Request.RouteValues["location"].ToString();
                    await context.Response.WriteAsync(g.BuildPage(context.Session, location));
                });
                endpoints.MapGet("{location}/{param1}={value1}", async context =>
                {
                    string location = context.Request.RouteValues["location"].ToString();
                    Dictionary<string, string> getParams = new Dictionary<string, string>();
                    getParams.Add(context.Request.RouteValues["param1"].ToString(), context.Request.RouteValues["value1"].ToString());
                    await context.Response.WriteAsync(g.BuildPage(context.Session, location, new ReadOnlyDictionary<string, string>(getParams)));
                });
                endpoints.MapGet("{location}/{param1}={value1}/{param2}={value2}", async context =>
                {
                    string location = context.Request.RouteValues["location"].ToString();
                    Dictionary<string, string> getParams = new Dictionary<string, string>();
                    getParams.Add(context.Request.RouteValues["param1"].ToString(), context.Request.RouteValues["value1"].ToString());
                    getParams.Add(context.Request.RouteValues["param2"].ToString(), context.Request.RouteValues["value2"].ToString());
                    await context.Response.WriteAsync(g.BuildPage(context.Session, location, new ReadOnlyDictionary<string, string>(getParams)));
                });
                endpoints.MapGet("{location}/{param1}={value1}/{param2}={value2}/{param3}={value3}", async context =>
                {
                    string location = context.Request.RouteValues["location"].ToString();
                    Dictionary<string, string> getParams = new Dictionary<string, string>();
                    getParams.Add(context.Request.RouteValues["param1"].ToString(), context.Request.RouteValues["value1"].ToString());
                    getParams.Add(context.Request.RouteValues["param2"].ToString(), context.Request.RouteValues["value2"].ToString());
                    getParams.Add(context.Request.RouteValues["param3"].ToString(), context.Request.RouteValues["value3"].ToString());
                    await context.Response.WriteAsync(g.BuildPage(context.Session, location, new ReadOnlyDictionary<string, string>(getParams)));
                });
            });
        }
    }
}
