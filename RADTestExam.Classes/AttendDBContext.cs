using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RADTestExam.Classes
{
    class AttendDBContext : DbContext
    {
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<LectureSubject> LectureSubjects { get; set; }
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Attendence> Attendences { get; set; }


        public AttendDBContext() : base(nameOrConnectionString: "RadTestConnection")
        {

        }

        public static AttendDBContext Create()
        {
            return new AttendDBContext();
        }
    }
}
