using System.ComponentModel.DataAnnotations;

namespace CritoProjectDG.Models;

public class NewsletterEntity
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();
    [EmailAddress]
    public string NewsletterEmail { get; set; } = null!;
}
