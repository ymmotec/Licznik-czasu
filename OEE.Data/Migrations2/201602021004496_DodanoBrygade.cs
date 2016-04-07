namespace OEE.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DodanoBrygade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Stan", "Brygada", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stan", "Brygada");
        }
    }
}
