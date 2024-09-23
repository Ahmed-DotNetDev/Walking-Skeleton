using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTO
{
    public class UserDto
    {
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Token { get; set; } = string.Empty;
    }
}