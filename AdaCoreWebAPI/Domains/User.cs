using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdaCoreWebAPI.Domains
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
