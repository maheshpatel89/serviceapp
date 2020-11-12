using AutoMapper;
using Exceptionless;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using ServiceApp.Entities;
using ServiceApp.Extensions;
using ServiceApp.Utilities;

namespace ServiceApp
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
            services.AddDbContext<ServiceAppQDbContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:serviceappQconnection"]));
            services.ConfigureRepositoryWrapper();
            services.AddControllers();
            services.AddAutoMapper(typeof(AutoMapperProfile));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Service API", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseExceptionless(Configuration.GetValue<string>("ExceptionLessApiKey"));

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Service API v1");
            });
            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
           
        }
    }
}
