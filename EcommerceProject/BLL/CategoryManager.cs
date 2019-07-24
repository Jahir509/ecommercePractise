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

    public class CategoryManager:Manager<Category>,ICategoryManager
    {
        
        public CategoryManager(ICategoryRepository repository) : base(repository)
        {
            
        }
    }
}
