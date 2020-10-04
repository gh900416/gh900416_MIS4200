namespace gh900416_MIS4200.Migrations.MISContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsMig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "firstName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "firstName", c => c.String());
        }
    }
}
