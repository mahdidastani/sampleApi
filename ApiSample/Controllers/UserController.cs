using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiSample.Context;
using ApiSample.Entities.Repositories;
using ApiSample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers
{
    [Route("api/User")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _user;
        ApiContext context;

        public UserController(IUserService user)
        {
            _user = user;
        }

        [HttpGet]
        public IEnumerable<User> GetallUsers() {

           return _user.getallUser();
        }

    }
}