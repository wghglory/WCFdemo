﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;

namespace BLL
{
    public class RoleService : IRoleService
    {
        public UserInfo GetUser(int id)
        {
            return new UserInfo() { Id = id, Name = "llllll" };
        }
    }
}
