namespace RegisteringUsers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDbTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        MajorCode = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RefMajors",
                c => new
                    {
                        MajorCode = c.Byte(nullable: false),
                        MajorDesc = c.String(),
                    })
                .PrimaryKey(t => t.MajorCode);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        MajorCode = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.RefMajors");
            DropTable("dbo.Instructors");
        }
    }
}
