using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using RestWithAsp_core5.Model;
using RestWithAsp_core5.Persistence;
using RestWithAsp_core5.Repository;
using RestWithAsp_core5.Repository.Implementation;
using RestWithAsp_core5.Services;
using RestWithAsp_core5.Services.Implementation;
using Serilog;

namespace RestWithAsp_core5
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public IWebHostEnvironment WebHostEvironment { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //WebHostEvironment = webHostEnvironment;

            //Log.Logger = new LoggerConfiguration()
            //    .WriteTo.Console()
            //    .CreateLogger();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddScoped<IGenericRepository<Person>, PersonRepository>();
            services.AddScoped<IGenericRepository<Book>, BookRepository>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddDbContext<PersonDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Connection")));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RestWithAsp_core5", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RestWithAsp_core5 v1"));
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
