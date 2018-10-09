namespace Agile_board.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Columns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        ColumnId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Columns", t => t.ColumnId, cascadeDelete: true)
                .Index(t => t.ColumnId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "ColumnId", "dbo.Columns");
            DropIndex("dbo.Tickets", new[] { "ColumnId" });
            DropTable("dbo.Tickets");
            DropTable("dbo.Columns");
        }
    }
}
