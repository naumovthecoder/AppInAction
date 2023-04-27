using AppInAction.DI.Interfaces;
using AppInAction.DI.Models;
using Microsoft.Extensions.DependencyInjection;

namespace AppInAction.DI.Services.EmailServices
{
    public static class EmailSenderServiceCollectionExtensions
    {
        public static IServiceCollection AddEmailSender(this IServiceCollection services)
        {
            services.AddScoped<IEmailSender, EmailSender>();
            services.AddSingleton<NetworkClient>();
            services.AddScoped<MessageFactory>();
            services.AddSingleton(provider => 
                new EmailServerSettings
                (
                    host: "smtp.server.com",
                    port: 25
                ));
            
            return services;
        }
    }
}