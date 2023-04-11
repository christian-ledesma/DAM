using Liga.Api.Repositories;
using Liga.Api.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Liga.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            AppSettings = new AppSettings();
        }

        public IConfiguration Configuration { get; }
        public AppSettings AppSettings { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();

            Configuration.GetSection("ConnectionStrings").Bind(AppSettings);

            services.AddSingleton(AppSettings);

            AddServices(services);
            AddRepositories(services);
        }

        public void AddServices(IServiceCollection services)
        {
            services.AddScoped<IEquipoService, EquipoService>();
            services.AddScoped<IJugadorService, JugadorService>();
        }

        public void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IEquipoRepository, EquipoRepository>();
            services.AddScoped<IJugadorRepository, JugadorRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Liga Manager API v1");
                });
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
