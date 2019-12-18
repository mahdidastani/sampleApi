using ApiSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample.Entities.Repositories
{
  public  interface IUserService
    {
        IEnumerable<User> getallUser();
    }
}
