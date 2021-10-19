using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace aspMVCDemo.Models.Auditing
{
    public class FullAuditedEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationTime { get; set; }

        // Soft Delete
        public bool? IsDeleted { get; set; }

        public Guid? DeleteUserId { get; set; }

        public DateTime? DeletionTime { get; set; }
    }
}