using biblioteca.WEBAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace biblioteca.WEBAPI.Date
{
    public class BibliotecaContext : DbContext
    {
        //public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) {}
        public DbSet<Aluno> Alunos {get; set;}
        public DbSet<Bibliotecaria> Bibliotecarias {get; set;}
        public DbSet<Emprestimo> Emprestimos {get; set;}
        public DbSet<Livro> Livros {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=madero*123;Persist Security Info=True;User ID=sa;Initial Catalog=biblioteca_db;Data Source=D00063261");
        }

    }

}