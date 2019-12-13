using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Stripe;

namespace Amaya
{
    public class Startup
    {
      public Startup(IHostingEnvironment env)
       {
           var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .AddEnvironmentVariables();
           Configuration = builder.Build();
       }

        public IConfigurationRoot Configuration { get; set; }


        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc();
            services.AddEntityFrameworkMySql()
         .AddDbContext<AmayaContext>(options => options
         .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));

            services.AddIdentity<ApplicationUser, IdentityRole>()
              .AddEntityFrameworkStores<AmayaContext>()
              .AddDefaultTokenProviders();

            services.Configure<CookiePolicyOptions>(options =>
            {

                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            services.AddMvc();
    //next three lines are configuration for Entity framework. These options are enabled through ToDoListContext.cs
    services.AddEntityFrameworkMySql()
      .AddDbContext<AmayaContext>(options => options
      .UseMySql(Configuration["ConnectionStrings:DefaultConnection"]));
            services.Configure<StripeSettings>(Configuration.GetSection("Stripe"));
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
          app.UseStaticFiles(); //need this for CSS styling
            StripeConfiguration.ApiKey = Configuration.GetSection("Stripe")["SecretKey"];
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
