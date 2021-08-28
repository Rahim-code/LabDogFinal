using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _29042021.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        
        [StringLength(maximumLength:100)]
        public string Image { get; set; }

        [Required]
        [StringLength(maximumLength:50)]
        public string FullName { get; set; }

        [StringLength(maximumLength:20)]
        public string Position { get; set; }

        [StringLength(maximumLength: 30)]
        public string CompanyName { get; set; }

        [StringLength(maximumLength: 500)]
        public string Text { get; set; }
        public int Rate { get; set; }

    }
}
