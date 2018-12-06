using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADTestExam.Classes
{
    [Table("StudentSubject")]
    class StudentSubject
    {
        [Key]
        [Column(Order =1)]
       
        public string Sid { get; set; }
        [ForeignKey("associatedSubject")]
        public virtual Subject associatedSubject { get; set; }
        [Key]
        [Column(Order = 2)]
       
        public int SubjectID { get; set; }
        [ForeignKey("associatedStudent")]
        public virtual Student associatedStudent { get; set; }
       
       
    }
}
