namespace Livraria.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alteração : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.LivroDetalheDTOes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LivroDetalheDTOes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titulo = c.String(),
                        Ano = c.Int(nullable: false),
                        Preco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Categoria = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
