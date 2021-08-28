using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _29042021.Models
{
    public class PlanFeature
    {
        public int Id { get; set; }
        public int PlanId { get; set; }

        [Required]
        [StringLength(maximumLength:30)]
        public string Name { get; set; }
     

        public Plan Plan { get; set; }
    }
}
