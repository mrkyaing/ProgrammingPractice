namespace SimpleMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialCreatedb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Email = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Address = c.String(),
                        FatherName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
        }
    }
}
