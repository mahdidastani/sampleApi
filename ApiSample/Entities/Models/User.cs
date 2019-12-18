using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiSample.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(200)]
        public string UserName { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }

        public int Age { get; set; }
    }
}
