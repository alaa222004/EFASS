using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASS.Iti
{
    internal class Course_Inst
    {
        public int InstractorId { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
        //public int Top_ID { get; set; }

        public string evaluate { get; set; }
    }
}
