using MoviePasta.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePasta.Models.TvModels
{
    public class TvCreate : TV
    {

        [Required]
        public double NumberStars { get; set; }

        [Required]
        public double AverageRating { get; set; }
    }
}
