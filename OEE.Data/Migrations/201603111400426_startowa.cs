namespace OEE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class startowa : DbMigration
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
                        Brygada = c.Int(nullable: false),
                        LiniaProdukcyjna = c.String(nullable: false),
                        OpisAwarii = c.String(),
                        OpisPrzezbrojenia = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Maszyna_MaszynaId = c.Int(),
                        TypZdarzenia_TypZdarzeniaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StanId)
                .ForeignKey("dbo.Maszyny", t => t.Maszyna_MaszynaId)
                .ForeignKey("dbo.TypZdarzenias", t => t.TypZdarzenia_TypZdarzeniaId, cascadeDelete: true)
                .Index(t => t.Maszyna_MaszynaId)
                .Index(t => t.TypZdarzenia_TypZdarzeniaId);
            
            CreateTable(
                "dbo.Maszyny",
                c => new
                    {
                        MaszynaId = c.Int(nullable: false, identity: true),
                        NazwaMaszyny = c.String(nullable: false, maxLength: 100),
                        Linia_LiniaId = c.Int(),
                    })
                .PrimaryKey(t => t.MaszynaId)
                .ForeignKey("dbo.Linia", t => t.Linia_LiniaId)
                .Index(t => t.Linia_LiniaId);
            
            CreateTable(
                "dbo.Linia",
                c => new
                    {
                        LiniaId = c.Int(nullable: false, identity: true),
                        NazwaLinii = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.LiniaId);
            
            CreateTable(
                "dbo.TypZdarzenias",
                c => new
                    {
                        TypZdarzeniaId = c.Int(nullable: false, identity: true),
                        NazwaZdarzenia = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.TypZdarzeniaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Stan", "TypZdarzenia_TypZdarzeniaId", "dbo.TypZdarzenias");
            DropForeignKey("dbo.Maszyny", "Linia_LiniaId", "dbo.Linia");
            DropForeignKey("dbo.Stan", "Maszyna_MaszynaId", "dbo.Maszyny");
            DropIndex("dbo.Maszyny", new[] { "Linia_LiniaId" });
            DropIndex("dbo.Stan", new[] { "TypZdarzenia_TypZdarzeniaId" });
            DropIndex("dbo.Stan", new[] { "Maszyna_MaszynaId" });
            DropTable("dbo.TypZdarzenias");
            DropTable("dbo.Linia");
            DropTable("dbo.Maszyny");
            DropTable("dbo.Stan");
        }
    }
}
