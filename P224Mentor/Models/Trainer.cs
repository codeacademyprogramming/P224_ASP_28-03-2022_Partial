using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace P224Mentor.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(255)]
        public string SurName { get; set; }
        [StringLength(1000)]
        public string Info { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }
        [StringLength(1000)]
        public string Twitter { get; set; }
        [StringLength(1000)]
        public string Instagram { get; set; }
        [StringLength(1000)]
        public string Facebook { get; set; }
        [StringLength(1000)]
        public string Linkedin { get; set; }

        public Category Category { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
