using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhoneBook.Domain.Core.People;

namespace PhoneBook.Infrastructure.DataLayer.People
{
    class PersonTagConfig : IEntityTypeConfiguration<PersonTag>
    {
        public void Configure(EntityTypeBuilder<PersonTag> builder)
        {

        }
    }
}
