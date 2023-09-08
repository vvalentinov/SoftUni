namespace _03._Songs_Above_Duration.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Producer
    {
        public Producer()
        {
            this.Albums = new HashSet<Album>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public string Pseudonym { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
