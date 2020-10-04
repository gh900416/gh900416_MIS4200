namespace gh900416_MIS4200.Migrations.MISContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "lastName", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "lastName", c => c.String());
        }
    }
}
