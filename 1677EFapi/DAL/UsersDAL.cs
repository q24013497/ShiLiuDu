using System;
using System.Collections.Generic;
using System.Linq;
using Model;
namespace DAL
{
    public class UsersDAL
    {
        DataContext db = new DataContext();
        public List<UserInfo> GetUser()
        {
            return db.us.ToList();
        }
    }
}
