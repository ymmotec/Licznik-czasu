namespace OEE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanoNazweLinii : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stan", "LiniaProdukcyjna", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stan", "LiniaProdukcyjna");
        }
    }
}
