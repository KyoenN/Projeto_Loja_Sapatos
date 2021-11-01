﻿using System;
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
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Venda> Vendas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
               .Property(p => p.nome)
               .HasMaxLength(300);

            modelBuilder.Entity<Cliente>()
                .Property(p => p.CPF)
                .HasMaxLength(11);

            modelBuilder.Entity<Cliente>()
                .Property(p => p.endereço)
                .HasMaxLength(300);

            modelBuilder.Entity<Cliente>()
                .Property(p => p.sexo)
                .HasMaxLength(1);

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

            modelBuilder.Entity<Modelo>()
                .Property(p => p.CodReferencia)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Modelo>()
                .Property(p => p.Nome)
                .HasMaxLength(200);

            modelBuilder.Entity<Modelo>()
                .Property(p => p.Cor)
                .HasMaxLength(50);

            modelBuilder.Entity<Modelo>()
                .Property(p => p.Tamanho)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder.Entity<Fornecedor>()
                .HasData(
                    new Fornecedor { Nome = "Adidas", CNPJ = "42274696000194", Endereco = "Rua Batatinha Frita, 123", Id = 1 },
                    new Fornecedor { Nome = "Nike", CNPJ = "36226675000109", Endereco = "Rua Batatinha Frita, 456", Id = 2 }
                );
        }
    }
}

