using PhoneBook.Domain.Contract.Common;
using PhoneBook.Domain.Contract.Phones;
using PhoneBook.Domain.Core.Phones;
using PhoneBook.Infrastructure.DataLayer.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Infrastructure.DataLayer.Phones
{
   public class PhoneRepository:BaseRepository<Phone>,IPhoneRepository
    {
        public PhoneRepository(PhoneBookContext context):base(context)
        {

        }
    }
}
