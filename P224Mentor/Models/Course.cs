using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace P224Mentor.Models
{
    public class Course
    {
        public int Id { get; set; }
        public Nullable<int> TrainerId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public double Price { get; set; }
        public int AvailableSeat { get; set; }
        public TimeSpan StartHour { get; set; }
        public TimeSpan EndHour { get; set; }
        [StringLength(1000)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }

        public Trainer Trainer { get; set; }
        public Category Category { get; set; }
        public IEnumerable<CourseTab> CourseTabs { get; set; }
    }
}
