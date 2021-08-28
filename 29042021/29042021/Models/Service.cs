using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _29042021.Models
{
    public class Service
    {
        public int Id { get; set; }

        [StringLength(maximumLength:20)]
        public string Icon { get; set; }

        [Required]
        [StringLength(maximumLength:100 )]
        public string Title { get; set; }

        [StringLength(maximumLength: 500)]
        public string Desc { get; set; }

        [StringLength(maximumLength: 10)]
        public string IconColor { get; set; }

        [StringLength(maximumLength: 10)]
        public string IconBackColor { get; set; }
    }
}
