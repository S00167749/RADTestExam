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
        [ForeignKey("associatedStudent")]
        public int SubjectID { get; set; }
       
        public virtual Subject associatedStudent { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("associatedLecture")]
        public int LectureID { get; set; }
       
        public virtual Lecturer associatedLecture { get; set; }
    }
}
