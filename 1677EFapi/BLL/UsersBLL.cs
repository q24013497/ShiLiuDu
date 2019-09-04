using System;
using System.Collections.Generic;
using DAL;
using Model;

namespace BLL
{
    public class UsersBLL
    {
        UsersDAL dal = new UsersDAL();

        public List<Users> GetUser()
        {
            return dal.GetUser();
        }
    }
}
