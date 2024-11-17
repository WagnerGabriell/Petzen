using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Petzen.Models.Entities;

namespace Petzen.Maps
{
    public class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        private readonly string _name;
        public BaseMap(string name){ 
            _name = name;
        }
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            if (!string.IsNullOrEmpty(_name)) {
                builder.ToTable(_name);
                builder.HasKey(a => a.Id);
                builder.Property(a => a.Id).HasColumnName("id").ValueGeneratedOnAdd();
            }
            throw new NotImplementedException();
        }
    }
}
