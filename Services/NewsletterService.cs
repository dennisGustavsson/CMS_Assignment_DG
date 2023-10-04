using CritoProjectDG.Contexts;
using CritoProjectDG.Models;
using Microsoft.EntityFrameworkCore;

namespace CritoProjectDG.Services;

public class NewsletterService
{
    private readonly DataContext _dataContext;

    public NewsletterService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task AddToNewsletterAsync(NewsletterForm newsletterEmail)
    {
        try
        {
            var email = await _dataContext.NewsletterEmails.FirstOrDefaultAsync(x => x.NewsletterEmail ==  newsletterEmail.Email);
            if (email == null)
            {
                email = new NewsletterEntity { NewsletterEmail = newsletterEmail.Email };
                _dataContext.NewsletterEmails.Add(email);
                await _dataContext.SaveChangesAsync();
            }
        } catch { }
    }



}
