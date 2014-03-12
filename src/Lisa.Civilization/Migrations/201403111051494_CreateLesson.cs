namespace Lisa.Civilization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLesson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Lessons");
        }
    }
}
