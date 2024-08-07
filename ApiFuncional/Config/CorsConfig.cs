﻿namespace ApiFuncional.Config
{
    public static class CorsConfig
    {
        public static WebApplicationBuilder AddCorsConfig(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("Devalopment", builder =>
                            builder
                             .AllowAnyOrigin()
                             .AllowAnyMethod()
                             .AllowAnyHeader());
                options.AddPolicy("Production", builder =>
                            builder
                                .WithOrigins("https://localhost:9000")
                                .WithMethods("POST")
                                .AllowAnyHeader());
            });

            return builder;
        }
    }
}
