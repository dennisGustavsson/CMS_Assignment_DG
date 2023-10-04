using CritoProjectDG.Contexts;
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

namespace CritoProjectDG.Controllers
{
    public class NewsletterController : SurfaceController
    {
        private readonly NewsletterService _newsletterService;
        public NewsletterController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, NewsletterService newsletterService) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _newsletterService = newsletterService;
        }


        [HttpPost]
        public async Task <IActionResult> NewsletterPost(NewsletterForm newsletter)
        {
            if(!ModelState.IsValid)
            {
                return CurrentUmbracoPage();
            }

            await _newsletterService.AddToNewsletterAsync(newsletter);
            return LocalRedirect("/");

        }
    }
}
