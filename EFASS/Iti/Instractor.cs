using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASS.Iti
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Adress { get; set; }
        public decimal HourRate { get; set; }

        public Department Department { get; set; }
        public int? DepartmentID { get; set; }

        public ICollection<Course>courses { get; set; }=new List<Course>();
    }
}
