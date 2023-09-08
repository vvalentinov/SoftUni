namespace _03._Songs_Above_Duration.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Writer
    {
        public Writer()
        {
            this.Songs = new HashSet<Song>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public string Pseudonym { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}
