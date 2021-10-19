namespace aspMVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Account_And_Profile_Entities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Username = c.String(nullable: false, maxLength: 64),
                        Password = c.String(nullable: false),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        DeleteUserId = c.Guid(),
                        DeletionTime = c.DateTime(),
                        Profile_Id = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Profile", t => t.Profile_Id)
                .Index(t => t.Username, name: "Username")
                .Index(t => t.Username, unique: true)
                .Index(t => t.Profile_Id);
            
            CreateTable(
                "dbo.Profile",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        CreationTime = c.DateTime(nullable: false),
                        LastModificationTime = c.DateTime(),
                        IsDeleted = c.Boolean(),
                        DeleteUserId = c.Guid(),
                        DeletionTime = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Account", "Profile_Id", "dbo.Profile");
            DropIndex("dbo.Account", new[] { "Profile_Id" });
            DropIndex("dbo.Account", new[] { "Username" });
            DropIndex("dbo.Account", "Username");
            DropTable("dbo.Profile");
            DropTable("dbo.Account");
        }
    }
}
