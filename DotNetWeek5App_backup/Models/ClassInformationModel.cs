using System.ComponentModel.DataAnnotations;

namespace DotNetWeek5App.Models
{
    public class ClassInformationModel
    {
        public int Id { get; set; }

        [Required]
        public string? ClassName { get; set; }

        [Required]
        [Range(1, 500)]
        public int StudentCount { get; set; }

        public string? Description { get; set; }
    }
}