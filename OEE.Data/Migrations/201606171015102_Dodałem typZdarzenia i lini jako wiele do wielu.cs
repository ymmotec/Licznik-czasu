namespace OEE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodałemtypZdarzeniailinijakowieledowielu : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TypZdarzeniaLinias",
                c => new
                    {
                        TypZdarzenia_TypZdarzeniaId = c.Int(nullable: false),
                        Linia_LiniaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TypZdarzenia_TypZdarzeniaId, t.Linia_LiniaId })
                .ForeignKey("dbo.TypZdarzenias", t => t.TypZdarzenia_TypZdarzeniaId, cascadeDelete: true)
                .ForeignKey("dbo.Linia", t => t.Linia_LiniaId, cascadeDelete: true)
                .Index(t => t.TypZdarzenia_TypZdarzeniaId)
                .Index(t => t.Linia_LiniaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TypZdarzeniaLinias", "Linia_LiniaId", "dbo.Linia");
            DropForeignKey("dbo.TypZdarzeniaLinias", "TypZdarzenia_TypZdarzeniaId", "dbo.TypZdarzenias");
            DropIndex("dbo.TypZdarzeniaLinias", new[] { "Linia_LiniaId" });
            DropIndex("dbo.TypZdarzeniaLinias", new[] { "TypZdarzenia_TypZdarzeniaId" });
            DropTable("dbo.TypZdarzeniaLinias");
        }
    }
}
