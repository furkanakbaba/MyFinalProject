using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();//data listeleme ve mesaj atma işlemini DataResultta Kodladık. IDataResul DataResultın İmzasını taşıyor.
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);//voidli işlemler yani data döndürmeyen işlemler için Result ı kullandık. IResult Resultın imzasını taşıyor.
        IDataResult<Product> GetById(int productId);
        IResult Update(Product product);




    }
}
