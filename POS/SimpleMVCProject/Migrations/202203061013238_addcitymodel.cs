namespace SimpleMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcitymodel : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.City");
        }
    }
}
