namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Student1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "Address", c => c.Int());
            AddColumn("dbo.Persons", "University", c => c.Int());
            AddColumn("dbo.Persons", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "Discriminator");
            DropColumn("dbo.Persons", "University");
            DropColumn("dbo.Persons", "Address");
        }
    }
}
