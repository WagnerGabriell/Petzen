using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petzen.Models.Entities;

namespace Petzen.Maps
{
    public class UsuarioMap : BaseMap<Usuarios>
    {
        public UsuarioMap() : base("usuarios"){}
        public override void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            base.Configure(builder);
            builder.Property(a => a.Name).HasColumnName("nome").HasMaxLength(150);

            builder.Property(a => a.Email).HasColumnName("email").IsRequired().HasMaxLength(100);
            builder.HasIndex(a => a.Email).IsUnique();

            builder.Property(a => a.Password).HasColumnName("password").IsRequired().HasMaxLength(50);

            builder.Property(a => a.NumeroTelefone).HasColumnName("number").IsRequired().HasMaxLength(12);

            builder.Property(a => a.IsAdmin).HasColumnName("isAdmin").HasDefaultValue(false);

        }
    }
}
