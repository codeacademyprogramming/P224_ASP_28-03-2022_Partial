using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P224Mentor.ViewModels
{
    public class TrainerVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Info { get; set; }
        public string Image { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }

        public CategoryVM Category { get; set; }
    }
}
