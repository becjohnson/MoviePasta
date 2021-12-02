using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePasta.Data
{
    public class TV : Movie
    {
        [Key]
        public int TvId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public MaturityRating MaturityRating { get; set; }
        [Required]
        public Category Category { get; set; }
        public double AverageStarRating { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
