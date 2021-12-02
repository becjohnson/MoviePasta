using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviePasta.Data
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        [Display(Name=" ")]
        public string FirstName { get; set; }
        [Display(Name=" ")]
        public string LastName { get; set; }
    }
}
