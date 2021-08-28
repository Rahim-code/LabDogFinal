using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _29042021.Models
{
    public class Partner
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(maximumLength:30)]
        public string Name { get; set; }

        [StringLength(maximumLength: 100)]
        public string Image { get; set; }

        [StringLength(maximumLength: 100)]
        public string HoverImage { get; set; }
    }
}
