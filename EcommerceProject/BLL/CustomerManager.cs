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
    public class CustomerManager:Manager<Customer>,ICustomerManager
    {
        public CustomerManager(ICustomerRepository repository):base(repository)          //This indicate to send the repository to base manager from
                                                                                        //Customer manager to Base Manager
        {
            
        }

    }
}
