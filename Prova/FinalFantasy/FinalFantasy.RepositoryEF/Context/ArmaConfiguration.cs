using FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.RepositoryEF
{
    internal class ArmaConfiguration : IEntityTypeConfiguration<Arma>
    {
        public void Configure(EntityTypeBuilder<Arma> builder)
        {
            builder.ToTable("Arma").HasKey(k => k.Nome);
            builder.Property("Danno").HasColumnType("int").IsRequired();

            builder.HasData(
                   new Arma { Nome = "Ascia", Danno = 8 },
                   new Arma { Nome = "Mazza", Danno = 5 },
                   new Arma { Nome = "Spada", Danno = 10 },
                   new Arma { Nome = "Bastone Magico", Danno = 10 },
                   new Arma { Nome = "Bacchetta", Danno = 5 },
                   new Arma { Nome = "Arco e Frecce", Danno = 8 },
                   new Arma { Nome = "Arco", Danno = 7 },
                   new Arma { Nome = "Clava", Danno = 5 },
                   new Arma { Nome = "Divinazione", Danno = 15 },
                   new Arma { Nome = "Fulmine", Danno = 10 },
                   new Arma { Nome = "Tempesta", Danno = 8 },
                   new Arma { Nome = "Tempesta Oscura", Danno = 15 }
                   );
                   


        }
    }
}