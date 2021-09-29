using Fiap.Aula03.Web.Exemplo01.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiap.Aula03.Web.Exemplo01.Persistencia
{
    //Classe que gerencia as entidades
    public class FiapFlixContext : DbContext
    {
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Produtora> Produtoras { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        //Construtir que recebe a string de conexão do banco
        public FiapFlixContext(DbContextOptions op) : base(op) { }
    }
}
