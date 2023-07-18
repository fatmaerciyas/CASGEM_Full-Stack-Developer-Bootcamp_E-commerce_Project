using Pizzapan.BusinessLayer.Abstract;
using Pizzapan.DataAccessLayer.Abstract;
using Pizzapan.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzapan.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _ContactDal;

        public ContactManager(IContactDal ContactDal)
        {
            _ContactDal = ContactDal;
        }

        public void TDelete(Contact t)
        {
            _ContactDal.Delete(t);
        }

        public Contact TGetByID(int id)
        {
            var Contact = _ContactDal.GetByID(id);
            return Contact;
        }

        public List<Contact> TGetContactByThanks()
        {
            return _ContactDal.GetContactByThanks();
        }

        public List<Contact> TGetList()
        {
            var categories = _ContactDal.GetList();
            return categories;
        }

        public void TInsert(Contact t)
        {
            _ContactDal.Insert(t);
        }

        public void TUpdate(Contact t)
        {
            _ContactDal.Update(t);
        }
    }
}
