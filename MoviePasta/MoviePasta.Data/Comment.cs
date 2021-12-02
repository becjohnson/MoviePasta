using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePasta.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [ForeignKey(nameof(RatingId))]
        public int RatingId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        [Display(Name="Comment")]
        public string Text { get; set; }
        [Required]
        [Display(Name="Created")]
        public DateTimeOffset Created { get; set; }
    }
}
