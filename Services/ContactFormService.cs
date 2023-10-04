using CritoProjectDG.Contexts;
using CritoProjectDG.Models;

namespace CritoProjectDG.Services;

public class ContactFormService
{
    private readonly DataContext _dataContext;

    public ContactFormService(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task AddContactFormRequestAsync(ContactForm contactForm)
    {
        try
        {
            var contact = await _dataContext.Contacts.FindAsync(contactForm.Email);

            if (contact == null)
            {
                contact = new ContactEntity { Name = contactForm.Name, Email = contactForm.Email };
                _dataContext.Contacts.Add(contact);
            }
            var message = new MessageEntity { Email = contactForm.Email, Content = contactForm.Message };
            _dataContext.Messages.Add(message);
            await _dataContext.SaveChangesAsync();
        } catch { }

    }

}
