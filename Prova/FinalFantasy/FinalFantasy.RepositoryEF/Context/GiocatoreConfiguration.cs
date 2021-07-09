using FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.RepositoryEF
{
    internal class GiocatoreConfiguration : IEntityTypeConfiguration<Giocatore>
    {
        public void Configure(EntityTypeBuilder<Giocatore> builder)
        {
            builder.ToTable("Giocatore").HasKey(k => k.Nickname);
        }
    }
}