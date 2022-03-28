using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace P224Mentor.Models
{
    public class CourseTab
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Title { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        public Course Course { get; set; }
    }
}
