using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePasta.Data
{
    public class StarRating
    {
        [Key]
        public int RatingId { get; set; }

        [Required]
        public double NumberStars { get; set; }
        public double AverageRating { get; set; }
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        [Required]
        [MaxLength(4000)]
        public string Comment { get; set; }

    }
}
