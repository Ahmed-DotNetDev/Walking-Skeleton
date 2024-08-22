using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class AppUser
    {
        //when i type any style is go to browser with camelCase
        public int Id { get; set; }
        public required string UserName { get; set; }
    }
}