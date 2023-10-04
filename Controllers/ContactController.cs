using CritoProjectDG.Models;
using CritoProjectDG.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace CritoProjectDG.Controllers;

public class ContactController : SurfaceController
{

    private readonly ContactFormService _contactFormService;



    public ContactController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, ContactFormService contactFormService) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
    {
        _contactFormService = contactFormService;
    }


    [HttpPost]
    public async Task <IActionResult> Index(ContactForm contactForm)
    {

        if(!ModelState.IsValid)
        {
            return CurrentUmbracoPage();
        }

        await _contactFormService.AddContactFormRequestAsync(contactForm);
        return LocalRedirect(contactForm.RedirectUrl!);
    }
}


