﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DictamenesMedicos.Model
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(UserModel user);
        void Remove(UserModel user);
        void Edit(UserModel user);
        void Update(UserModel user);

        UserModel Get(int id);
        UserModel GetByUsername(string username);
    }
}
