using aspMVCDemo.Models.Auditing;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspMVCDemo.Models.Account
{
    [Table("Account")]
    public class Account : FullAuditedEntity
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public Account()
        {
        }

        private Account(string username,
                        string password)
        {
            this.Id = Guid.NewGuid();
            this.Username = username;
            this.Password = password;

            this.CreationTime = DateTime.Now;
           
        }

        public static Account Create(CreateAccountDto input) {

            var acc = new Account(
                input.Username,
                input.Password);

            return acc;
        }

        public void Delete() {
            this.DeletionTime = DateTime.Now;
            this.IsDeleted = true;
        }

    }
}