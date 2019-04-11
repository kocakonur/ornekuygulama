namespace $safeprojectname$.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ilk : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Yazars", "YazarAdiSoyadi", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yazars", "YazarAdiSoyadi", c => c.String());
        }
    }
}
