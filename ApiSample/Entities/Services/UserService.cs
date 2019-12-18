using ApiSample.Context;
using ApiSample.Entities.Repositories;
using ApiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample.Entities.Services
{
    public class UserService: IUserService
    {
          ApiContext _db { get; set; }
        public UserService(ApiContext apiContext)
        {
            _db = apiContext;
        }
        public IEnumerable<User> getallUser()
        {
            return _db.User;
        }
    }
}
