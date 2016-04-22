﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBLL;
using Model;

namespace BLL
{
    public class UserService : IUserService
    {
        public string Show()
        {
            Console.Write("bll.userService show method gets called");
            return DateTime.Now.ToString();
        }

        public UserInfo GetUser(string userId)
        {
            return new UserInfo() { Id = int.Parse(userId), Name = DateTime.Now.ToString() };
        }


    }
}
