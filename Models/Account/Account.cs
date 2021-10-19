using aspMVCDemo.Models.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Services.Description;
using aspMVCDemo.HelperServices;
using aspMVCDemo.Models.Roles;

namespace aspMVCDemo.Models.Account
{
    
    [Table("Account")]
    public class Account : FullAuditedEntity
    {
        [Required]
        [Index(nameof(Username))]
        [MaxLength(64)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        // Profile_Id (reference) to the Id in Profile entity
        public Profile.Profile Profile { get; set; }

        public virtual ICollection<Role> Roles { get; set; }

        public Account()
        {
        }

        private Account(string username,
                        string password,
                        string name)
        {
            Id = Guid.NewGuid();
            Username = username;
            Password = Authentication.Hashing(password);
            Profile = new Profile.Profile
            {
                Name = name
            };

            CreationTime = DateTime.Now;
           
        }

        public static Account Create(CreateAccountDto input) {

            var acc = new Account(
                input.Username,
                input.Password,
                input.Name);

            return acc;
        }

        public void Update(UpdateAccountDto input)
        {
            Username = input.Username;
            Password = input.Password;
            LastModificationTime = DateTime.Now;
        }

        public void Delete() {
            DeletionTime = DateTime.Now;
            IsDeleted = true;
        }

    }
}