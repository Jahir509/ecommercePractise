using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace BLL.Contracts
{
    public interface IProductManager:IManager<Product>
    {
        ICollection<Product> GetByPrice(double price);
        ICollection<Product> GetByName(string name);
        ICollection<Product> GetByActive(bool isActive);
    }
}
