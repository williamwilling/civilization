namespace Lisa.Civilization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddQuestionToLesson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Lessons", "Question", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Lessons", "Question");
        }
    }
}
