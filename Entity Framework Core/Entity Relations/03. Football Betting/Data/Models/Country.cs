﻿namespace _03._Football_Betting.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        public Country()
        {
            this.Towns = new HashSet<Town>();
        }

        [Key]
        public int CountryId { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Town> Towns { get; set; }
    }
}
