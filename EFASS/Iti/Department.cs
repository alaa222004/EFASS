using EFASS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFASS.Iti
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
       
        public DateTime HiringDate { get; set; }

      
        public ICollection<Student> Students { get; set; }
        public ICollection<Instructor> Instructors { get; set; }


    }
}
