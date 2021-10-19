using System;

namespace aspMVCDemo.Models.Account
{
    public class UpdateAccountDto
    {
        public Guid Id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public UpdateAccountDto(Guid Id, string username, string password)
        {
            this.Id = Id;
            this.Username = username;
            this.Password = password;
        }
    }
}