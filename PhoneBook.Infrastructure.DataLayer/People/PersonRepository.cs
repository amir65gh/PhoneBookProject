using PhoneBook.Domain.Contract.People;
using PhoneBook.Domain.Core.People;
using PhoneBook.Infrastructure.DataLayer.Common;

namespace PhoneBook.Infrastructure.DataLayer.People
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(PhoneBookContext context) : base(context)
        {

        }
    }
}
