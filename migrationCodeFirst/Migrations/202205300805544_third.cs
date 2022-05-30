namespace migrationCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.THEME",
                c => new
                    {
                        NUMTHEME = c.Int(nullable: false),
                        LIBTHEME = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.NUMTHEME);
            
            AddColumn("dbo.OUVRAGE", "NUMTHEME", c => c.Int());
            CreateIndex("dbo.OUVRAGE", "NUMTHEME");
            AddForeignKey("dbo.OUVRAGE", "NUMTHEME", "dbo.THEME", "NUMTHEME");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OUVRAGE", "NUMTHEME", "dbo.THEME");
            DropIndex("dbo.OUVRAGE", new[] { "NUMTHEME" });
            DropColumn("dbo.OUVRAGE", "NUMTHEME");
            DropTable("dbo.THEME");
        }
    }
}
