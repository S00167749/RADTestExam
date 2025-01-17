﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADTestExam.Classes
{
    [Table("Subject")]
    class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }

       // public virtual ICollection<StudentSubject> studentSubjects { get; set; }
       public virtual ICollection<Attendence> attendes { get; set; }
       // public virtual ICollection<LectureSubject> lectureSubjects { get; set; }
    }
}
