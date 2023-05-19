using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Odev_aw2.Data.Context;
using Odev_aw2.Data.UnitOfWork;
using Odev_aw2.RestExtension;

namespace Odev_aw2;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }


    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Odev_aw2", Version = "v1.0" });
        });
           // services.AddStaffSwaggerExtension();
        services.AddDbContext<Aw2DbContext>(opts => opts.UseSqlServer(Configuration.GetConnectionString("MsSqlConnection")));
        services.AddScoped<IUnitOfWork, UnitOfWork>();



    }


    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();

        }

        app.UseSwagger();
        app.UseSwaggerUI(c =>
        {
            c.DefaultModelsExpandDepth(-1);
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Odev_aw2");
            c.DocumentTitle = "Odev_aw2";
        });

        app.UseHttpsRedirection();

        // add auth 
        app.UseAuthentication();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}

