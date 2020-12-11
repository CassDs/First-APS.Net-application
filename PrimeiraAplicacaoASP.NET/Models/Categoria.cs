using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraAplicacaoASP.NET.Models
{
    public class Categoria
    {
        public int Id { get; set; } //Chave primaria das tabelas do banco de dados

        public string Descricao { get; set; } //Descrição dos itens
    }
}
