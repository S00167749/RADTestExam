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
        [ForeignKey("associatedStudent")]
        public string Sid { get; set; }
     
        public virtual Student associatedStudent { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("associatedSubject")]
        public int SubjectID { get; set; }
      
        public virtual Subject associatedSubject { get; set; }


     //get the names right

    }
}
