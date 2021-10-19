using System;

namespace aspMVCDemo.Models.Account
{
    public class AccountDto
    {
        public Guid Id;
        
        public string Username;

        public string Password;

        public DateTime CreationTime;

        public DateTime LastModificationTime;

        public long Profile_Id;

        public string Name;
    }
}