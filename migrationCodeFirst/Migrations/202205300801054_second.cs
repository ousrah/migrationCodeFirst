namespace migrationCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EDITEUR", "LANGUE", c => c.String(maxLength: 26));
            AddColumn("dbo.DEPOT", "PAYSDEP", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DEPOT", "PAYSDEP");
            DropColumn("dbo.EDITEUR", "LANGUE");
        }
    }
}
