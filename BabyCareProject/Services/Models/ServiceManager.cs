using BabyCareProject.Services.Contracts;

namespace BabyCareProject.Services.Models;
public class ServiceManager : IServiceManager
{
    private readonly IAboutService _aboutService;
    private readonly IContactService _contactService;
    private readonly IEventService _eventService;
    private readonly IGalleryService _galleryService;
    private readonly IInstructorService _instructorService;
    private readonly IMessageService _messageService;
    private readonly IProductService _productService;
    private readonly IHizmetService _hizmetService;
    private readonly ISubscriberService _subscriberService;
    private readonly ITestimonialService _testimonialService;

    public ServiceManager(IAboutService aboutService, IContactService contactService,
        IEventService eventService, IGalleryService galleryService,
        IInstructorService instructorService, IMessageService messageService,
        IProductService productService, IHizmetService hizmetService,
       ISubscriberService subscriberService,
        ITestimonialService testimonialService)
    {
        _aboutService = aboutService;
        _contactService = contactService;
        _eventService = eventService;
        _galleryService = galleryService;
        _instructorService = instructorService;
        _messageService = messageService;
        _productService = productService;
        _hizmetService = hizmetService;
        _subscriberService = subscriberService;
        _testimonialService = testimonialService;
    }
    public IAboutService AboutService => _aboutService;
    public IContactService ContactService => _contactService;
    public IEventService EventService => _eventService;
    public IGalleryService GalleryService => _galleryService;
    public IInstructorService InstructorService => _instructorService;
    public IMessageService MessageService => _messageService;
    public IProductService ProductService => _productService;
    public IHizmetService HizmetService => _hizmetService;
    public ISubscriberService SubscriberService => _subscriberService;
    public ITestimonialService TestimonialService => _testimonialService;
}
