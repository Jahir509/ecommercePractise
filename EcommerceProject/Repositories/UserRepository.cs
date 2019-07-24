using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Repositories.Base;
using Repositories.Contracts;

namespace Repositories
{
    public class UserRepository:Repository<UserType>,IUserRepository
    {
        
    }
}
