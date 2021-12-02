using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePasta.Data
{
    public class StarRating : TV
    {
        [Key]
        public int RatingId { get; set; }

        [Required]
        public double NumberStars { get; set; }
        public double AverageRating { get; set; }
       
        [Required]
        [MaxLength(4000)]
        public string Comment { get; set; }

    }
}
