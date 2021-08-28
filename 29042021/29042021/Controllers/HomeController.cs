using _29042021.Models;
using _29042021.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _29042021.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Partners = _context.Partners.ToList(),
                Services = _context.Services.ToList(),
                Testimonials = _context.Testimonials.ToList(),
                Plans = _context.Plans.Include(x=>x.PlanFeatures).ToList()
            };


            return View(homeVM);
        }
    }
}
