using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PhoneBook.Infrastructure.DataLayer.Common
{
    public class PhoneBookContextFactory : IDesignTimeDbContextFactory<PhoneBookContext>
    {
        public PhoneBookContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PhoneBookContext>();
            builder.UseSqlServer("Server=.;Database=PhoneBookDb;Integrated Security=True;MultipleActiveResultSets=true");
            return new PhoneBookContext(builder.Options);
        }
    }
}
