namespace RegisteringUsers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKeys : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Instructors");
            DropPrimaryKey("dbo.Students");
            AddColumn("dbo.Instructors", "InstructorId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Students", "StudentId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Instructors", "InstructorId");
            AddPrimaryKey("dbo.Students", "StudentId");
            DropColumn("dbo.Instructors", "ID");
            DropColumn("dbo.Students", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Instructors", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Students");
            DropPrimaryKey("dbo.Instructors");
            DropColumn("dbo.Students", "StudentId");
            DropColumn("dbo.Instructors", "InstructorId");
            AddPrimaryKey("dbo.Students", "ID");
            AddPrimaryKey("dbo.Instructors", "ID");
        }
    }
}
