namespace CFFromDatabase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataTypeChangedInDepartmentTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String(nullable: false, maxLength: 50, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String());
        }
    }
}
