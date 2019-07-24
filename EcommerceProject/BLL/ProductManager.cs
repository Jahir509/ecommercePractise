using System;
using System.Collections.Generic;
using System.Text;
using BLL.Base;
using BLL.Contracts;
using Models;
using Repositories;
using Repositories.Contracts;

namespace BLL
{
    public class ProductManager:Manager<Product>,IProductManager
    {

        public ProductManager(IProductRepository repository):base(repository)
        {

        }


        //Filtering With InterFace
        public ICollection<Product> GetByPrice(double price)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public ICollection<Product> GetByActive(bool isActive)
        {
            throw new NotImplementedException();
        }
    }
}
