using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePasta.Data
{
    public class StarRating
    {
        [Key]
        public int RatingId { get; set; }
        [ForeignKey(nameof(MovieId))]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        [ForeignKey(nameof(TvId))]
        public int TvId { get; set; }
        public virtual TV Tv { get; set; }
        [Required]
        public double NumberStars { get; set; }
        [Required]
        public double AverageRating { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public string MovieDescription { get; set; }
        [Required]
        [MaxLength(4000)]
        public string Comment { get; set; }
    }
}
