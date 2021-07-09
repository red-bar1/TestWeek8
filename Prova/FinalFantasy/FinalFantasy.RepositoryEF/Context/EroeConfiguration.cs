using FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.RepositoryEF
{
    internal class EroeConfiguration : IEntityTypeConfiguration<Eroe>
    {
        public void Configure(EntityTypeBuilder<Eroe> builder)
        {
            builder.ToTable("Eroe").HasKey(k => k.Nome);
            builder.Property("Livello").HasColumnType("int").IsRequired();
            //builder.Property("PuntiVita").HasColumnType("int").IsRequired();
            builder.HasOne(e => e.Arma).WithMany(a => a.Eroi).HasForeignKey(e => e.ArmaNome);
            builder.Property("CategoriaEroe").IsRequired();
            builder.HasOne(e => e.Giocatore).WithMany(g => g.Eroi).HasForeignKey(e => e.GiocatoreNickname);
            builder.Property("PuntiEsperienza").HasColumnType("int");
        }
    }
}