using System;
using System.Collections.Generic;
using System.Text;
using BLL.Base;
using BLL.Contracts;
using Models;
using Repositories.Contracts;

namespace BLL
{
    public class UserManager:Manager<UserType>,IUserManager
    {
        public UserManager(IUserRepository userRepository) : base(userRepository)
        {

        }
    }
}
