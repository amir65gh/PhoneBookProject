using PhoneBook.Domain.Contract.People;
using PhoneBook.Domain.Core.People;

namespace PhoneBook.Services.ApplicationService.People
{
    public class AddNewPerson : IAddNewPerson
    {
        private readonly IPersonRepository _personRepository;
        public AddNewPerson(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        
        Person IAddNewPerson.Execute(Person person)
        {
            //ADD Business Logic if needed.
            return _personRepository.Add(person);
        }
    }
}
