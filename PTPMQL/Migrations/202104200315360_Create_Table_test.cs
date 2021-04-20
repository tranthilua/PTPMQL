namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tests",
                c => new
                    {
                        MyProperty = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MyProperty);
            
            AlterColumn("dbo.Accounts", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Password", c => c.String());
            DropTable("dbo.tests");
        }
    }
}
