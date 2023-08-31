namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foreignkey : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Students", "AddressId");
            AddForeignKey("dbo.Students", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Students", new[] { "AddressId" });
        }
    }
}
