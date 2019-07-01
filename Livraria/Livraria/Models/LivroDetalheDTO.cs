using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    public class LivroDetalheDTO
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public decimal Preco { get; set; }
        public string Categoria { get; set; }
    }
}