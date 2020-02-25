namespace PhoneBook.Domain.Core.Phones
{
    public class Phone:BaseEntity
    {
        public string PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
