﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MobileProjectAPI.Data;
using Swashbuckle.AspNetCore.Swagger;

namespace MobileProjectAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //CORS
            services.AddCors(o => o.AddPolicy("MyPolicy", builder => { 
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader(); 
            }));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<CookbookContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
            //Swagger
            services.AddSwaggerGen(c => { 
                c.SwaggerDoc("v1", new Info { 
                    Title = "My API", Version = "v1"
                });
            });

        }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, CookbookContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseCors("MyPolicy");

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger(); 
            app.UseSwaggerUI(c => { 
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Member API v1"); 
            });

            DBInitializer.Initialize(context);


        }
    }
}
