using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //interface metotları default public tir
    public interface IProductDal
    {
        //ürünleri listeledim
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId); //bu ürünleri kategoriye göre filtrele
    }
}
