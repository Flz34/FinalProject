﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //iş katmanın da kullanacağımız servis otomasyonu
       //tüm ürünleri lsiteleyecek
        List<Product> GetAll();
    }
}
