namespace MvcApplication2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenamedExceptionField : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ExceptionDbs", name: "Message", newName: "ExceptionMessage");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.ExceptionDbs", name: "ExceptionMessage", newName: "Message");
        }
    }
}
