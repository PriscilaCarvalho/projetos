namespace Livraria.Migrations
{
    using Livraria.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Livraria.Models.LivrariaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Livraria.Models.LivrariaContext context)
        {
         

            context.Livros.AddOrUpdate(x => x.Id,
                new Livro()
                {
                    Id = 1,
                    Titulo = "Titulo J",
                    Ano = 2010,         
                    Preco = 49.99M,
                    Categoria = "Drama"
                },
                new Livro()
                {
                    Id = 2,
                    Titulo = "Titulo D",
                    Ano = 2010,                    
                    Preco = 49.99M,
                    Categoria = "Comédia"
                },
                new Livro()
                {
                    Id = 3,
                    Titulo = "Titulo Z",
                    Ano = 2010,                    
                    Preco = 49.99M,
                    Categoria = "Terror"                
                },
                new Livro()
                {
                    Id = 4,
                    Titulo = "Titulo F",
                    Ano = 2010,                    
                    Preco = 49.99M,
                    Categoria = "Anime"
                },
                new Livro()
                {
                    Id = 5,
                    Titulo = "Titulo I",
                    Ano = 2010,                    
                    Preco = 49.99M,
                    Categoria = "Anime"
                }
                );
        }
    }
}
