using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Instagram.Identity.Application;

public static class DependencyInjection
{
    public static void AddSwagger(this IServiceCollection services)
    {
        services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "My API",
                Version = "v1"
            });

            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter your access token in the Bearer field",
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey
            });
        });
    }
}