namespace LisToDo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class novalista : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ListToDoes", "DataConclusao", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ListToDoes", "DataConclusao", c => c.DateTime(nullable: false));
        }
    }
}
