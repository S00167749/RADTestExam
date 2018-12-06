namespace RADTestExam.Classes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Attendence",
                c => new
                    {
                        AttendanceID = c.Int(nullable: false, identity: true),
                        AttendenceDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        SubjectID = c.Int(nullable: false),
                        StudentID = c.String(),
                        Present = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.AttendanceID);
            
            CreateTable(
                "dbo.Lecturer",
                c => new
                    {
                        LectureID = c.Int(nullable: false, identity: true),
                        LectureName = c.String(),
                    })
                .PrimaryKey(t => t.LectureID);
            
            CreateTable(
                "dbo.LectureSubject",
                c => new
                    {
                        SubjectID = c.Int(nullable: false),
                        LectureID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SubjectID, t.LectureID });
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Sid = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        SecondName = c.String(),
                    })
                .PrimaryKey(t => t.Sid);
            
            CreateTable(
                "dbo.StudentSubject",
                c => new
                    {
                        Sid = c.String(nullable: false, maxLength: 128),
                        SubjectID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Sid, t.SubjectID });
            
            CreateTable(
                "dbo.Subject",
                c => new
                    {
                        SubjectID = c.Int(nullable: false, identity: true),
                        SubjectName = c.String(),
                    })
                .PrimaryKey(t => t.SubjectID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subject");
            DropTable("dbo.StudentSubject");
            DropTable("dbo.Student");
            DropTable("dbo.LectureSubject");
            DropTable("dbo.Lecturer");
            DropTable("dbo.Attendence");
        }
    }
}
