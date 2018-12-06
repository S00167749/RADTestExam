using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADTestExam.Classes
{
    [Table("Attendence")]
    class Attendence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttendanceID { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime AttendenceDate { get; set; }
        public int SubjectID { get; set; }
        public string StudentID { get; set; }
        public bool Present { get; set; }

    }
}
