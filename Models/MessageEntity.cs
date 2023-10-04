using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CritoProjectDG.Models;

public class MessageEntity
{
    [Key]
    public int Id { get; set; }
    public string Email { get; set; } = null!;
    public string Content { get; set; } = null!;
    [ForeignKey("Email")]
    public ContactEntity Contact { get; set; } = null!;
}
