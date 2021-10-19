using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aspMVCDemo.Models.Account
{
    public class CreateAccountDto
    {
        [Required]
        [StringLength(64, MinimumLength = 10)]
        public string Username { get; set; }

        [StringLength(128, MinimumLength = 8)]
        public string Password { get; set; }

        [StringLength(128, MinimumLength = 8)]
        public string ConfirmPassword { get; set; }

        [StringLength(64, MinimumLength = 8)]
        public string Name { get; set; }

        public CreateAccountDto()
        {
        }

        public CreateAccountDto(string username, string password, string confirmPassword, string name)
        {
            this.Username = username;
            this.Password = password;
            this.ConfirmPassword = confirmPassword;
            this.Name = name;
        }
    }
}