using _29042021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _29042021.ViewModels
{
    public class HomeViewModel
    {
        public List<Partner> Partners { get; set; }
        public List<Service> Services { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Plan> Plans { get; set; }

    }
}
