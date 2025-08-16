using EFASS.Iti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EFASS.Models
{

    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Address { get; set; }
        public int age { get; set; }

        public Department Department { get; set; }

        public int DepartmentId {  get; set; }





    }
}
