using Microsoft.AspNetCore.Mvc;
using P224Mentor.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P224Mentor.Models;
using Microsoft.EntityFrameworkCore;
using P224Mentor.ViewModels;

namespace P224Mentor.Controllers
{
    public class TrainerController : Controller
    {
        private readonly MentorDbContext _context;

        public TrainerController(MentorDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.TrainerCount = _context.Trainers.Count();
            IEnumerable<TrainerVM> trainers = await _context.Trainers
                .Include(t => t.Category)
                .OrderByDescending(t => t.Id)
                .Take(6)
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
                }).ToListAsync();

            return View(trainers);
        }

        public async Task<IActionResult> Load(int? skip)
        {
            if(skip == null) return BadRequest();

            if(skip > _context.Trainers.Count()) return BadRequest();   

            IEnumerable<TrainerVM> trainers = await _context.Trainers
                .Include(t => t.Category)
                .OrderByDescending(t => t.Id)
                .Skip((int)skip)
                .Take(6)
                .Select(x=>new TrainerVM 
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
                }).ToListAsync();

            return PartialView("_TrainerPartial",trainers);
        }
    }
}
