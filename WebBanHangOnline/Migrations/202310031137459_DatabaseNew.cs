namespace WebBanHangOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseNew : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.tb_review", "ProductId");
            AddForeignKey("dbo.tb_review", "ProductId", "dbo.tb_Product", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_review", "ProductId", "dbo.tb_Product");
            DropIndex("dbo.tb_review", new[] { "ProductId" });
        }
    }
}
