using PhoneBook.Domain.Core.People;

namespace PhoneBook.Domain.Contract.People
{
    public interface IAddNewPerson
    {
        Person Execute(Person person);
    }
}
