namespace Agile_board.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "Name", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "Name", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
