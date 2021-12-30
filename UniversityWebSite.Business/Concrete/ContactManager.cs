using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityWebSite.Business.Abstract;
using UniversityWebSite.DataAccess.Abstract.Repositories;
using UniversityWebSite.Entities.Concrete;

namespace UniversityWebSite.Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactRepository _contactRepository;

        public ContactManager(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }


        public IEnumerable<Contact> GetAllContact()
        {
            return _contactRepository.GetAll();
        }

        public Contact GetContactById(int id)
        {
            return _contactRepository.Get(x => x.Id == id);
        }

        public void UpdateContact(Contact contact)
        {
            _contactRepository.Update(contact);
        }
    }
}
