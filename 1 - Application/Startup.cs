using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;
using Telefonia.Crud.Infra.Database.Context;
using Telefonia.Crud.Infra.Database.Repository;
using Telefonia.Crud.Services;
using Telefonia.Crud.WebApi.Middleware;

namespace poc_telefonia_mica
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
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Api Telefonia",
                    Description = "CRUD Api Telefonia",
                    TermsOfService = new Uri("https://example.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Mica Rodrigues",
                        Email = "mica.msr@gmail.com",
                        Url = new Uri("https://www.linkedin.com/in/mica-rodrigues-1b533641"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://example.com/license"),
                    }
                });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });

            services.AddDbContext<TelefoniaDatabaseContext>(
                option => option.UseSqlServer(Configuration.GetConnectionString("Default")),
                ServiceLifetime.Scoped
           );


            services.AddScoped<IPlanoServices, PlanoServices>();
            services.AddScoped<IPlanoTelefoniaRepository, PlanoTelefoniaRepository>();
            services.AddScoped<IDddPlanoRepository, DddPlanoRepository>();
            services.AddScoped<ITipoPlanoRepository, TipoPlanoRepository>();
            services.AddScoped<IOperadoraPlanoRepository, OperadoraPlanoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware(typeof(ErrorHandlingMiddleware));
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
