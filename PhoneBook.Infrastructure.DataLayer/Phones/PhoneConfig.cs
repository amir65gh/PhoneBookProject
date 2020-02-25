using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Domain.Core.Phones;

namespace PhoneBook.Infrastructure.DataLayer.Phones
{
    public class PhoneConfig : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.Property(c => c.PhoneType).IsRequired().HasMaxLength(20);
        }
    }
}
