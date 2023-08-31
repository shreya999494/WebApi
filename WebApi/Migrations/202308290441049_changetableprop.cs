namespace WebApi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetableprop : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Students", new[] { "AddressId" });
            AddColumn("dbo.Students", "Address", c => c.String(maxLength: 8000, unicode: false));
            DropColumn("dbo.Students", "AddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "AddressId", c => c.Int(nullable: false));
            DropColumn("dbo.Students", "Address");
            CreateIndex("dbo.Students", "AddressId");
            AddForeignKey("dbo.Students", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
    }
}
