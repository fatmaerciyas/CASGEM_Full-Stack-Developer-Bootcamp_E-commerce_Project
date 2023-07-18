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
    public class ProductImageManager : IProductImageService
    {
        private readonly IProductImageDal _ProductImageDal;

        public ProductImageManager(IProductImageDal ProductImageDal)
        {
            _ProductImageDal = ProductImageDal;
        }

        public void TDelete(ProductImage t)
        {
            _ProductImageDal.Delete(t);
        }

        public ProductImage TGetByID(int id)
        {
            var ProductImage = _ProductImageDal.GetByID(id);
            return ProductImage;
        }

        public List<ProductImage> TGetList()
        {
            var categories = _ProductImageDal.GetList();
            return categories;
        }

        public void TInsert(ProductImage t)
        {
            _ProductImageDal.Insert(t);
        }

        public void TUpdate(ProductImage t)
        {
            _ProductImageDal.Update(t);
        }
    }
}
