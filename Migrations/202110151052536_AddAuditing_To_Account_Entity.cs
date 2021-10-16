namespace aspMVCDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuditing_To_Account_Entity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Account", "CreationTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Account", "LastModificationTime", c => c.DateTime());
            AddColumn("dbo.Account", "IsDeleted", c => c.Boolean());
            AddColumn("dbo.Account", "DeleteUserId", c => c.Guid());
            AddColumn("dbo.Account", "DeletionTime", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Account", "DeletionTime");
            DropColumn("dbo.Account", "DeleteUserId");
            DropColumn("dbo.Account", "IsDeleted");
            DropColumn("dbo.Account", "LastModificationTime");
            DropColumn("dbo.Account", "CreationTime");
        }
    }
}
