using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PrimeiraAplicacaoASP.NET.Models
{
    public class Context : DbContext //Extendendo da class DbContext
    {
        //Passando a class Categoria para criação de tabelas
        public DbSet<Categoria> Categorias { get; set; }
        //Passando a class Produtos para criação de tabelas
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Configurando o banco de Dados
        {
            //Utilizando o SLQ Server, e fazendo o set da criação do banco
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBTest;Integrated Security=True");
        }
    }
}
