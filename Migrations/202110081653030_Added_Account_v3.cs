namespace aspMVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_Account_v3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        username = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Account");
        }
    }
}
