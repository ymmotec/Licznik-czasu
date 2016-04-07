namespace OEE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanoWymaganiaDlaPol : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stan", "TypZdarzenia_TypZdarzeniaId", "dbo.TypZdarzenias");
            DropIndex("dbo.Stan", new[] { "TypZdarzenia_TypZdarzeniaId" });
            AddColumn("dbo.TypZdarzenias", "NazwaZdarzenia", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Stan", "TypZdarzenia_TypZdarzeniaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Stan", "TypZdarzenia_TypZdarzeniaId");
            AddForeignKey("dbo.Stan", "TypZdarzenia_TypZdarzeniaId", "dbo.TypZdarzenias", "TypZdarzeniaId", cascadeDelete: true);
            DropColumn("dbo.TypZdarzenias", "NazwaZdarzeia");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TypZdarzenias", "NazwaZdarzeia", c => c.String(nullable: false, maxLength: 50));
            DropForeignKey("dbo.Stan", "TypZdarzenia_TypZdarzeniaId", "dbo.TypZdarzenias");
            DropIndex("dbo.Stan", new[] { "TypZdarzenia_TypZdarzeniaId" });
            AlterColumn("dbo.Stan", "TypZdarzenia_TypZdarzeniaId", c => c.Int());
            DropColumn("dbo.TypZdarzenias", "NazwaZdarzenia");
            CreateIndex("dbo.Stan", "TypZdarzenia_TypZdarzeniaId");
            AddForeignKey("dbo.Stan", "TypZdarzenia_TypZdarzeniaId", "dbo.TypZdarzenias", "TypZdarzeniaId");
        }
    }
}
