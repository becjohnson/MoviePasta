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
        [ForeignKey(nameof(StarRating))]
        public int Star { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public DateTimeOffset Created { get; set; }
    }
}
