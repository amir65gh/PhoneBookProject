using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Core.People;
using PhoneBook.Domain.Core.Phones;
using PhoneBook.Domain.Core.Tags;
using PhoneBook.Infrastructure.DataLayer.People;
using PhoneBook.Infrastructure.DataLayer.Phones;
using PhoneBook.Infrastructure.DataLayer.Tags;

namespace PhoneBook.Infrastructure.DataLayer.Common
{
    public class PhoneBookContext : DbContext
    {
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<PersonTag> Persontags { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public PhoneBookContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PhoneConfig());
            modelBuilder.ApplyConfiguration(new PersonTagConfig());
            modelBuilder.ApplyConfiguration(new PersonConfig());
            modelBuilder.ApplyConfiguration(new TagConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
