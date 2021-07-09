using FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy.RepositoryEF
{
    class FinalFantasyContext : DbContext
    {
        public DbSet<Giocatore> Giocatori { get; set; }
        public DbSet<Eroe> Eroi { get; set; }
        public DbSet<Mostro> Mostri { get; set; }
        public DbSet<Arma> Arma { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optBuilder)
        {
            optBuilder.UseSqlServer(@"Persist Security Info = False; Integrated Security = True; 
                                    Initial Catalog = FinalFantasyDB; Server = .\SQLEXPRESS");
        }

        public FinalFantasyContext() : base () { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration<Giocatore>(new GiocatoreConfiguration());
            builder.ApplyConfiguration<Eroe>(new EroeConfiguration());
            builder.ApplyConfiguration<Mostro>(new MostroConfiguration());
            builder.ApplyConfiguration<Arma>(new ArmaConfiguration());
        }


    }
}
