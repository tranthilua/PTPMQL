namespace PTPMQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_QuanLy : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuanLy",
                c => new
                    {
                        MaQuanLy = c.String(nullable: false, maxLength: 128),
                        TenQuanLy = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.MaQuanLy);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.QuanLy");
        }
    }
}
