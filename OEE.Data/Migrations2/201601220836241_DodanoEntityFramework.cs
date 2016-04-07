namespace OEE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanoEntityFramework : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stan",
                c => new
                    {
                        StanId = c.Int(nullable: false, identity: true),
                        GodzinaUruchomienia = c.DateTime(nullable: false),
                        CzasTrwania = c.Int(nullable: false),
                        OpisAwarii = c.String(),
                        OpisPrzezbrojenia = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Maszyna_MaszynaId = c.Int(),
                        TypZdarzenia_TypZdarzeniaId = c.Int(),
                    })
                .PrimaryKey(t => t.StanId)
                .ForeignKey("dbo.Maszyny", t => t.Maszyna_MaszynaId)
                .ForeignKey("dbo.TypZdarzenias", t => t.TypZdarzenia_TypZdarzeniaId)
                .Index(t => t.Maszyna_MaszynaId)
                .Index(t => t.TypZdarzenia_TypZdarzeniaId);
            
            CreateTable(
                "dbo.Maszyny",
                c => new
                    {
                        MaszynaId = c.Int(nullable: false, identity: true),
                        NazwaMaszyny = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.MaszynaId);
            
            CreateTable(
                "dbo.TypZdarzenias",
                c => new
                    {
                        TypZdarzeniaId = c.Int(nullable: false, identity: true),
                        NazwaZdarzeia = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TypZdarzeniaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stan", "TypZdarzenia_TypZdarzeniaId", "dbo.TypZdarzenias");
            DropForeignKey("dbo.Stan", "Maszyna_MaszynaId", "dbo.Maszyny");
            DropIndex("dbo.Stan", new[] { "TypZdarzenia_TypZdarzeniaId" });
            DropIndex("dbo.Stan", new[] { "Maszyna_MaszynaId" });
            DropTable("dbo.TypZdarzenias");
            DropTable("dbo.Maszyny");
            DropTable("dbo.Stan");
        }
    }
}
