using AppInAction.DI.MultipleImplementation.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace AppInAction.DI.MultipleImplementation.Services
{
    public static class SenderServiceCollectionExtensions
    {
        public static IServiceCollection AddSenders(this IServiceCollection services)
        {
            services.AddScoped<IMessageSender, EmailSender>();
            services.TryAddScoped<IMessageSender, FacebookSender>();
            services.TryAddScoped<IMessageSender, SmsSender>();
            
            return services;
        }
    }
}