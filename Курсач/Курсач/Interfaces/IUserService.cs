﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Курсач.Data.DTO;
using Курсач.Data.Entities;

namespace Курсач.Core.Interfaces
{
    public interface IUserService
    {
        Task<User> RegisterUser(LoginData loginData);
        Task<string> LoginUser(LoginData loginData);
        Task<User> GetUser(int id);
        string GetToken();
    }

}
