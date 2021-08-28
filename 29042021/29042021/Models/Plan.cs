using _29042021.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _29042021.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public PlanType Type { get; set; }
        public double Price { get; set; }

        public List<PlanFeature> PlanFeatures { get; set; }
    }
}
