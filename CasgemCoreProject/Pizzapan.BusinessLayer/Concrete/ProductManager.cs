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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _ProductDal;

        public ProductManager(IProductDal ProductDal)
        {
            _ProductDal = ProductDal;
        }

        public void TDelete(Product t)
        {
            _ProductDal.Delete(t);
        }

        public Product TGetByID(int id)
        {
            var Product = _ProductDal.GetByID(id);
            return Product;
        }

        public List<Product> TGetList()
        {
            var categories = _ProductDal.GetList();
            return categories;
        }

        public List<Product> TGetProductListByCategory()
        {
            return _ProductDal.GetProductsWithCategory();
        }

        public void TInsert(Product t)
        {
            _ProductDal.Insert(t);
        }

        public void TUpdate(Product t)
        {
            _ProductDal.Update(t);
        }
    }
}
