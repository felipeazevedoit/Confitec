using Microsoft.AspNetCore.Builder;
using Usuarios.Servico.Configuracao;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using Usuarios.Infraestrutura.Dados.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using System.IO;

namespace Usuarios.Servico
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
            
            services.AddDbContext<Contexto>
                (options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // Contexto
            services.AddDatabaseSetup(Configuration);

            // AutoMapper
            services.AddAutoMapperSetup();

            // Swagger Config
            services.AddSwaggerSetup();

            // ASP.NET HttpContext dependency
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            // Injeção de Dependencias
            services.AddDependencyInjectionSetup();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
            app.UseSwagger();

            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1"));
        }
    }
}
