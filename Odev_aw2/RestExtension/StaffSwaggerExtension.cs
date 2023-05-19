using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

namespace Odev_aw2.RestExtension;

public static class StaffSwaggerExtension
{
    public static void AddStaffSwaggerExtension(this IServiceCollection services)
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "Odev_aw2", Version = "v1.0" });


            //var securityScheme = new OpenApiSecurityScheme
            //{
            //    Name = "Odev_aw2",
            //    Description = "Enter JWT Bearer token **_only_**",
            //    In = ParameterLocation.Header,
            //    Type = SecuritySchemeType.Http,
            //    Scheme = "bearer",
            //    BearerFormat = "JWT",
            //    Reference = new OpenApiReference
            //    {
            //        Id = JwtBearerDefaults.AuthenticationScheme,
            //        Type = ReferenceType.SecurityScheme
            //    }
            //};
            //c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
            //c.AddSecurityRequirement(new OpenApiSecurityRequirement
            //{
            //    {securityScheme, new string[] { }}
            //});
        });
    }
}
