using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADTestExam.Classes
{
    [Table("LectureSubject")]
    class LectureSubject
    {
        [Key]
        [Column(Order =1)]     
        public int SubjectID { get; set; }
        [ForeignKey("associatedStudent")]
        public virtual Student associatedStudent { get; set; }

        [Key]
        [Column(Order = 2)]       
        public int LectureID { get; set; }
        [ForeignKey("associatedLecture")]
        public virtual Lecturer associatedLecture { get; set; }
    }
}
