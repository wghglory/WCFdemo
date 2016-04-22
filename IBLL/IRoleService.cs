﻿using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    //1. 添加引用 System.ServiceModel.   interface add tag
    [ServiceContract]
    public interface IRoleService
    {
        [OperationContract]
        UserInfo GetUser(int id);
    }
}
