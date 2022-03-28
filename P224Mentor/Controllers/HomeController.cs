using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using P224Mentor.DAL;
using P224Mentor.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace P224Mentor.Controllers
{
    public class HomeController : Controller
    {
        private readonly MentorDbContext _context;

        public HomeController(MentorDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            HomeVM homeVM = new HomeVM
            {
                Trainers = await _context.Trainers.Include(t => t.Category).OrderByDescending(t => t.Id).Take(3)
                .Select(x => new TrainerVM
                {
                    Id = x.Id,
                    Facebook = x.Facebook,
                    Image = x.Image,
                    Info = x.Info,
                    Instagram = x.Instagram,
                    Linkedin = x.Linkedin,
                    Name = x.Name,
                    SurName = x.SurName,
                    Twitter = x.Twitter,
                    Category = new CategoryVM
                    {
                        Id = x.Category.Id,
                        Name = x.Category.Name
                    }
                }).ToListAsync()
            };

            return View(homeVM);
        }
    }
}
