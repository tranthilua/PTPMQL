namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "NhanVienID", c => c.String());
            AddColumn("dbo.Persons", "CongTy", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "CongTy");
            DropColumn("dbo.Persons", "NhanVienID");
        }
    }
}
