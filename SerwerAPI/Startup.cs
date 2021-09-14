using Jering.Javascript.NodeJS;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using SerwerAPI.Data;
using SerwerAPI.Models;
using SerwerAPI.Services;
using SerwerAPI.staticMembers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerwerAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddNodeServices(options =>
            {
                options.ProjectPath = "C:\\Program Files\\nodejs";
            });

            services.AddDbContext<DataContext>(x => x.UseSqlite(@"Data Source=C:\APIDatabase\UsersLocation.db"));
            services.AddAutoMapper(typeof(Startup));
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ISignsService, SignsService>();
            services.AddScoped<IUserLocationRepository, UserLocationRepository>();
            services.AddScoped<IZoneService, ZoneService>();
            services.AddScoped<IZoneLocationRepository, ZoneLocationRepository>();
            services.AddScoped<ISignsRepository, SignsRepository>();
            services.AddSwaggerGen();
            services.AddControllers();
            JSEngine.runBackgroundTask();
           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                });

                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
