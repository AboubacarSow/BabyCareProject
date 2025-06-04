using BabyCareProject.Services.Contracts;
using BabyCareProject.Services.Models;

namespace BabyCareProject.Infrastructure.Extensions;

public static class ServicesExtension
{
    public static void ConfigureServices(this IServiceCollection services)
    {
        services.AddScoped<IAboutService, AboutManager>();
        services.AddScoped<IContactService, ContactManager>();
        services.AddScoped<IEventService, EventManager>();
        services.AddScoped<IGalleryService, GalleryManager>();
        services.AddScoped<IHizmetService, HizmetManager>();
        services.AddScoped<IInstructorService, InstructorManager>();
        services.AddScoped<IMessageService, MessageManager>();
        services.AddScoped<IProductService, ProductManager>();
        services.AddScoped<IServiceManager, ServiceManager>();
        services.AddScoped<ISocialMediaService, SocialMediaManager>();
        services.AddScoped<ISubscriberService, SubscriberManager>();
        services.AddScoped<ITestimonialService, TestimonialManager>();
    }
}
