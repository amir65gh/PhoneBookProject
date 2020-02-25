using PhoneBook.Domain.Contract.Tags;
using PhoneBook.Domain.Core.Tags;
using PhoneBook.Infrastructure.DataLayer.Common;

namespace PhoneBook.Infrastructure.DataLayer.Tags
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(PhoneBookContext context) : base(context)
        {

        }
    }
}
