﻿namespace BabyCareProject.Services.Contracts;

public interface IServiceManager
{
    IAboutService AboutService { get; }
    IContactService ContactService { get; }
    IEventService EventService { get; }
    IGalleryService GalleryService { get; }
    IInstructorService InstructorService { get; }
    IMessageService MessageService { get; }
    IProductService ProductService { get; }
    IHizmetService HizmetService {  get; }
    ISubscriberService SubscriberService { get; }
    ITestimonialService TestimonialService { get; }
}
