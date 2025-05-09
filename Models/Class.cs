using System.ComponentModel.DataAnnotations;

namespace DotNetWeek5App.Models
{
    public class Class
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int PersonCount { get; set; }

        public string Description { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}