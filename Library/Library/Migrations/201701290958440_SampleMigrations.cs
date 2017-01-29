namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SampleMigrations : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "PublishingHouse", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Books", "PublishingHouse");
        }
    }
}
