namespace CFFromDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePersonnelTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personnels",
                c => new
                    {
                        TcNo = c.String(nullable: false, maxLength: 11),
                        AdSoyad = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.TcNo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personnels");
        }
    }
}
