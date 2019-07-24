using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Models;
using Repositories.Base;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        public override ICollection<Product> GetAll()
        {
            return db.Products.Include(c => c.Category).ToList();
        }
    }
}
