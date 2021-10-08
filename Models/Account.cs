using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace aspMVCDemo.Models
{
    [Table("Account")]
    public class Account
    {
        public Guid Id { get; set; }

        public string username { get; set; }

        public string password { get; set; }
    }
}