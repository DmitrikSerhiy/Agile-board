namespace Agile_board.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveColumnAnotation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Columns", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Columns", "Name", c => c.String(nullable: false, maxLength: 40));
        }
    }
}
