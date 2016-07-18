namespace OEE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class KluczkombinowanywProdukcie : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Stan", "Produkt_ProduktId", "dbo.Produkty");
            DropIndex("dbo.Stan", new[] { "Produkt_ProduktId" });
            RenameColumn(table: "dbo.Stan", name: "Produkt_ProduktId", newName: "Produkt_NazwaProduktu");
            DropPrimaryKey("dbo.Produkty");
            AddColumn("dbo.Stan", "Produkt_NazwaElementu", c => c.String(maxLength: 128));
            AlterColumn("dbo.Stan", "Produkt_NazwaProduktu", c => c.String(maxLength: 128));
            AlterColumn("dbo.Produkty", "ProduktId", c => c.Int(nullable: false));
            AlterColumn("dbo.Produkty", "NazwaProduktu", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Produkty", "NazwaElementu", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Produkty", new[] { "NazwaProduktu", "NazwaElementu" });
            CreateIndex("dbo.Stan", new[] { "Produkt_NazwaProduktu", "Produkt_NazwaElementu" });
            AddForeignKey("dbo.Stan", new[] { "Produkt_NazwaProduktu", "Produkt_NazwaElementu" }, "dbo.Produkty", new[] { "NazwaProduktu", "NazwaElementu" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stan", new[] { "Produkt_NazwaProduktu", "Produkt_NazwaElementu" }, "dbo.Produkty");
            DropIndex("dbo.Stan", new[] { "Produkt_NazwaProduktu", "Produkt_NazwaElementu" });
            DropPrimaryKey("dbo.Produkty");
            AlterColumn("dbo.Produkty", "NazwaElementu", c => c.String());
            AlterColumn("dbo.Produkty", "NazwaProduktu", c => c.String());
            AlterColumn("dbo.Produkty", "ProduktId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Stan", "Produkt_NazwaProduktu", c => c.Int());
            DropColumn("dbo.Stan", "Produkt_NazwaElementu");
            AddPrimaryKey("dbo.Produkty", "ProduktId");
            RenameColumn(table: "dbo.Stan", name: "Produkt_NazwaProduktu", newName: "Produkt_ProduktId");
            CreateIndex("dbo.Stan", "Produkt_ProduktId");
            AddForeignKey("dbo.Stan", "Produkt_ProduktId", "dbo.Produkty", "ProduktId");
        }
    }
}
