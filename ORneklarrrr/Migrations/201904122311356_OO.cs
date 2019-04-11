namespace $safeprojectname$.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OO : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yazars", "YazarEmailadresi", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yazars", "YazarEmailadresi");
        }
    }
}
