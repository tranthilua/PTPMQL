namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_KhachHang_KhachHangID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.KhachHang");
            AlterColumn("dbo.KhachHang", "KhachHangID", c => c.String(nullable: false, maxLength: 20));
            AddPrimaryKey("dbo.KhachHang", "KhachHangID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.KhachHang");
            AlterColumn("dbo.KhachHang", "KhachHangID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.KhachHang", "KhachHangID");
        }
    }
}
