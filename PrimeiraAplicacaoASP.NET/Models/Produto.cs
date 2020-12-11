using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraAplicacaoASP.NET.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int CategoriasIde { get; set; }

        public Categoria Categoria { get; set; }
    }
}
