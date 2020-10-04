namespace gh900416_MIS4200.Migrations.MISContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsMig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Classes", "title", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Classes", "title", c => c.String());
        }
    }
}
