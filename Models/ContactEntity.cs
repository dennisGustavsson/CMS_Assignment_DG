using System.ComponentModel.DataAnnotations;

namespace CritoProjectDG.Models;

public class ContactEntity
{
    [Key]
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;

    [Required]
    public string Name { get; set; } = null!;


    [Required]
    public ICollection<MessageEntity> Messages { get; set; } = null!;
}
