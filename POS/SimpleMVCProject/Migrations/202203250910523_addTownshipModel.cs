namespace SimpleMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addTownshipModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.City",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        No = c.String(),
                        Name = c.String(),
                        Email = c.String(),
                        DOB = c.DateTime(nullable: false),
                        Address = c.String(),
                        FatherName = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Township",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        ZipCode = c.String(),
                        CityId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.City", t => t.CityId)
                .Index(t => t.CityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Township", "CityId", "dbo.City");
            DropIndex("dbo.Township", new[] { "CityId" });
            DropTable("dbo.Township");
            DropTable("dbo.Student");
            DropTable("dbo.City");
        }
    }
}
