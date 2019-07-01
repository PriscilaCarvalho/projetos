using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    public class Livro
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }        

    }
}