namespace OEE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodanomodeldlaproduktuelementuikoloru : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Elementy",
                c => new
                    {
                        ElementId = c.Int(nullable: false, identity: true),
                        NazwaElementu = c.String(nullable: false, maxLength: 100),
                        Produkt_ProduktId = c.Int(),
                    })
                .PrimaryKey(t => t.ElementId)
                .ForeignKey("dbo.Produkty", t => t.Produkt_ProduktId)
                .Index(t => t.Produkt_ProduktId);
            
            CreateTable(
                "dbo.Produkty",
                c => new
                    {
                        ProduktId = c.Int(nullable: false, identity: true),
                        NazwaProduktu = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ProduktId);
            
            CreateTable(
                "dbo.Kolory",
                c => new
                    {
                        KolorId = c.Int(nullable: false, identity: true),
                        NazwaKoloru = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.KolorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Elementy", "Produkt_ProduktId", "dbo.Produkty");
            DropIndex("dbo.Elementy", new[] { "Produkt_ProduktId" });
            DropTable("dbo.Kolory");
            DropTable("dbo.Produkty");
            DropTable("dbo.Elementy");
        }
    }
}
