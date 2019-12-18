using ApiSample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample.Context
{
    public class ApiContext:DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options):base(options)
        {

        }


        public DbSet<ApiSample.Models.User> User { get; set; }
    }
}
