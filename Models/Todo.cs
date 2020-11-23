using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public string Title { get; set; }
    }
}
