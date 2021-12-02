using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePasta.Data
{
    public enum MaturityRating { G, PG, NC_17, R, MA, TVY,TV_Y7, TV_G, TV_PG, TV_14, TV_MA, }
    public enum Category { Action, Horror, SciFi, Fantasy, Drama, Mystery, Romance, Thriller, Western, Animation, Documentary, RomCom, GameShow}
    public class Movie : Tv
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [JsonConverter(typeof(StringEnumConverter))]
        public MaturityRating MaturityRating { get; set; }
        [Required]
        public Category Catetegory { get; set; }
        public double AverageStarRating { get; set; }
        [MaxLength(8000)]
        public string Description { get; set; }
    }
}
