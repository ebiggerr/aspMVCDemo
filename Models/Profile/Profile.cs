using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using aspMVCDemo.Models.Auditing;

namespace aspMVCDemo.Models.Profile
{
    [Table("Profile")]
    public class Profile : FullAuditedEntityLong
    {
        public string Name { get; set; }
        
        public Account.Account Account { get; set; }

        public Profile()
        {
            CreationTime = DateTime.Now;
            
        }
    }
}