namespace _01._Student_System.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(2048)")]
        public string Url { get; set; }

        [Required]
        public ResourceType ResourceType { get; set; }

        [Required]
        public int CourseId { get; set; }
        public  Course Course { get; set; }
    }
}
