namespace RADTestExam.Classes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmigration : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Attendence", "SubjectID");
            CreateIndex("dbo.LectureSubject", "SubjectID");
            CreateIndex("dbo.LectureSubject", "LectureID");
            CreateIndex("dbo.StudentSubject", "Sid");
            CreateIndex("dbo.StudentSubject", "SubjectID");
            AddForeignKey("dbo.LectureSubject", "LectureID", "dbo.Lecturer", "LectureID", cascadeDelete: true);
            AddForeignKey("dbo.Attendence", "SubjectID", "dbo.Subject", "SubjectID", cascadeDelete: true);
            AddForeignKey("dbo.LectureSubject", "SubjectID", "dbo.Subject", "SubjectID", cascadeDelete: true);
            AddForeignKey("dbo.StudentSubject", "Sid", "dbo.Student", "Sid", cascadeDelete: true);
            AddForeignKey("dbo.StudentSubject", "SubjectID", "dbo.Subject", "SubjectID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentSubject", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.StudentSubject", "Sid", "dbo.Student");
            DropForeignKey("dbo.LectureSubject", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.Attendence", "SubjectID", "dbo.Subject");
            DropForeignKey("dbo.LectureSubject", "LectureID", "dbo.Lecturer");
            DropIndex("dbo.StudentSubject", new[] { "SubjectID" });
            DropIndex("dbo.StudentSubject", new[] { "Sid" });
            DropIndex("dbo.LectureSubject", new[] { "LectureID" });
            DropIndex("dbo.LectureSubject", new[] { "SubjectID" });
            DropIndex("dbo.Attendence", new[] { "SubjectID" });
        }
    }
}
