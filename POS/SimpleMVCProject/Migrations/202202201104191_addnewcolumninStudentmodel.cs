namespace SimpleMVCProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewcolumninStudentmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "No", c => c.String());
            AddColumn("dbo.Student", "IsDelete", c => c.Boolean(nullable: false));
            AddColumn("dbo.Student", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Student", "UpdatedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "UpdatedDate");
            DropColumn("dbo.Student", "CreatedDate");
            DropColumn("dbo.Student", "IsDelete");
            DropColumn("dbo.Student", "No");
        }
    }
}
