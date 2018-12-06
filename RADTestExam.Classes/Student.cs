using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADTestExam.Classes
{
    [Table("Student")]
    class Student
    {
        [Key]
        public string Sid { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public virtual ICollection<StudentSubject> studentSubjects { get; set; }
        //public virtual ICollection<Attendence> attendes { get; set; }
    }
}
