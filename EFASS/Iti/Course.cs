using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASS.Iti
{
    public class Course
    {
        public int Id { get; set; }
        public string Duration { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public ICollection<Stud_Course> student { get; set; }
        public ICollection<Stud_Course> instractor { get; set; }
    }
}
