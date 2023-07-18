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
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _DiscountDal;

        public DiscountManager(IDiscountDal DiscountDal)
        {
            _DiscountDal = DiscountDal;
        }

        public void TDelete(Discount t)
        {
            _DiscountDal.Delete(t);
        }

        public Discount TGetByID(int id)
        {
            var Discount = _DiscountDal.GetByID(id);
            return Discount;
        }

        public List<Discount> TGetList()
        {
            var categories = _DiscountDal.GetList();
            return categories;
        }

      

        public void TInsert(Discount t)
        {
            _DiscountDal.Insert(t);
        }

        public void TUpdate(Discount t)
        {
            _DiscountDal.Update(t);
        }
    }
}
