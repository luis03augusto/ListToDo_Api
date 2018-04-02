namespace LisToDo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ListToDoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomeItem = c.String(),
                        DescricaoItem = c.String(),
                        Status = c.String(),
                        DataDeCriacao = c.DateTime(nullable: false),
                        DataConclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ListToDoes");
        }
    }
}
