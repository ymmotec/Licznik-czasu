namespace OEE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodałemproduktkolor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kolory",
                c => new
                    {
                        KolorId = c.Int(nullable: false, identity: true),
                        NazwaKoloru = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.KolorId);
            
            CreateTable(
                "dbo.Produkty",
                c => new
                    {
                        ProduktId = c.Int(nullable: false, identity: true),
                        NazwaProduktu = c.String(),
                        NazwaElementu = c.String(),
                    })
                .PrimaryKey(t => t.ProduktId);
            
            AddColumn("dbo.Stan", "Kolor_KolorId", c => c.Int());
            AddColumn("dbo.Stan", "Produkt_ProduktId", c => c.Int());
            CreateIndex("dbo.Stan", "Kolor_KolorId");
            CreateIndex("dbo.Stan", "Produkt_ProduktId");
            AddForeignKey("dbo.Stan", "Kolor_KolorId", "dbo.Kolory", "KolorId");
            AddForeignKey("dbo.Stan", "Produkt_ProduktId", "dbo.Produkty", "ProduktId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stan", "Produkt_ProduktId", "dbo.Produkty");
            DropForeignKey("dbo.Stan", "Kolor_KolorId", "dbo.Kolory");
            DropIndex("dbo.Stan", new[] { "Produkt_ProduktId" });
            DropIndex("dbo.Stan", new[] { "Kolor_KolorId" });
            DropColumn("dbo.Stan", "Produkt_ProduktId");
            DropColumn("dbo.Stan", "Kolor_KolorId");
            DropTable("dbo.Produkty");
            DropTable("dbo.Kolory");
        }
    }
}
