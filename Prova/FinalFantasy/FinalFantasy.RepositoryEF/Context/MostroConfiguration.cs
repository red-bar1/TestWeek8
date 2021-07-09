using FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.RepositoryEF
{
    internal class MostroConfiguration : IEntityTypeConfiguration<Mostro>
    {
        public void Configure(EntityTypeBuilder<Mostro> builder)
        {
            builder.ToTable("Mostro").HasKey(k => k.Nome);
            builder.Property("Livello").HasColumnType("int").IsRequired();
            //builder.Property("PuntiVita").HasColumnType("int").IsRequired();
            builder.HasOne(e => e.Arma).WithMany(a => a.Mostri).HasForeignKey(e => e.ArmaNome);
            builder.Property("CategoriaMostro").IsRequired();

            builder.HasData(
                new Mostro
                {
                    Nome = "Qwerty",
                    CategoriaMostro = CategoriaMostro.Ghost,
                    ArmaNome = "Arco",
                    //Arma = new Arma
                    //{
                    //    Nome = "Arco",
                    //    Danno = 7,
                    //},
                    Livello = 1
                },
                new Mostro
                {
                    Nome = "Satan",
                    CategoriaMostro = CategoriaMostro.Lucifer,
                    ArmaNome = "Fulmine",
                    //Arma = new Arma
                    //{
                    //    Nome = "Fulmine",
                    //    Danno = 8,
                    //},
                    Livello = 2
                },
                new Mostro
                {
                    Nome = "Mefisto",
                    CategoriaMostro = CategoriaMostro.Lucifer,
                    ArmaNome = "Tempesta Oscura",
                    //Arma = new Arma
                    //{
                    //    Nome = "Tempesta Oscura",
                    //    Danno = 15,
                    //},
                    Livello = 3
                });

                

        }
    }
}