namespace FinanceManagementApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        TransactionId = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.String(),
                        Date = c.DateTime(nullable: false),
                        Type = c.String(),
                        Notes = c.String(),
                        UserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TransactionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transactions");
        }
    }
}
