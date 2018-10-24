using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
namespace WebAppiSwagger
{
    /// <summary>
    /// 
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        /// <summary>
        /// 
        /// </summary>
        public IConfiguration Configuration { get; }        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {                
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // Configurando o serviço de documentação do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Title = "Web Api",
                        Version = "v1",
                        Description = "Web Api",
                        Contact = new Contact
                        {
                            Name = "Fúlvio Cezar Canducci Dias",
                            Url = "https://github.com/fulviocanducci",
                            Email = "fulviocanducci@hotmail.com"
                        }
                    });
                var (PathApplication, NameApplication) = GetPlatformServicesValue();                                
                c.IncludeXmlComments(Path.Combine(PathApplication, $"{NameApplication}.xml"));
            });            
            services.AddMvc()                
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.Configure<RouteOptions>(o =>
            {
                o.LowercaseUrls = true;
            });

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public (string PathApplication, string NameApplication) GetPlatformServicesValue()
        {
            return (PlatformServices.Default.Application.ApplicationBasePath, PlatformServices.Default.Application.ApplicationName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json",
                    "Conversor de Temperaturas");
            });
        }
    }
}
