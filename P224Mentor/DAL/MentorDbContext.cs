using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P224Mentor.Models;

namespace P224Mentor.DAL
{
    public class MentorDbContext : DbContext
    {
        public MentorDbContext(DbContextOptions<MentorDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseTab> CourseTabs { get; set; }
    }
}
