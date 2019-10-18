using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Scooby.Infra.EFCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Scooby.Infra.Repository;
using Scooby.Infra.Repository.impl;

namespace Scooby.Api
{
    public class Startup
    {
        private IConfiguration _Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            _Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ScoobyContext>(options =>
            {
                options.UseSqlServer(
                    _Configuration.GetConnectionString("DefaultConnection"),
                    assembly => assembly.MigrationsAssembly(typeof(Startup).Assembly.FullName));

            });
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddApiVersioning();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
