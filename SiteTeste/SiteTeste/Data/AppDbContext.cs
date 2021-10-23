using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SiteTeste.Models;

namespace SiteTeste.Data
{
    // Faz todo o gerenciamento para se conectar com o banco de dados
    public class AppDbContext : DbContext
    {
        //construtor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        /*  DbSet : Sua função é pegar o model/classe e transformar em uma tabela do banco de dados 
            ORM = object-relational mapping */

        //faz mapeamento do fornecedor e deixa disponível no banco de dados
        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fornecedor>()
                .Property(p => p.Nome)
                .HasMaxLength(200);

            modelBuilder.Entity<Fornecedor>()
                .Property(p => p.Endereco)
                .HasMaxLength(200);

            modelBuilder.Entity<Fornecedor>()
                .Property(p => p.CNPJ)
                .HasMaxLength(14)
                .IsRequired();
        }
    }
}

