namespace MVCDemo1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validationapplied : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.Courses", "Name", c => c.String());
        }
    }
}
