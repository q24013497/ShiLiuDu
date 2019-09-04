﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BLL;
using Model;
namespace _1677EFapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        UsersBLL bll = new UsersBLL();

        [HttpGet]
        public List<Users> GetUser()
        {
            return bll.GetUser();
        }
    }
}