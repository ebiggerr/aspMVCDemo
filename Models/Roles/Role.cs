using System.Collections.Generic;
using aspMVCDemo.Models.Auditing;

namespace aspMVCDemo.Models.Roles
{
    public class Role: FullAuditedEntityLong
    {
        public string Name { get; set; }

        public string Description { get; set; }
        
        public virtual ICollection<Account.Account> Accounts { get; set; }
    }
}