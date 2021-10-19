using System;
using System.ComponentModel.DataAnnotations;

namespace aspMVCDemo.Models.Auditing
{
    public class FullAuditedEntityLong
    {
        [Key]
        public long Id { get; set; }
        
        public DateTime CreationTime { get; set; }

        public DateTime? LastModificationTime { get; set; }

        // Soft Delete
        public bool? IsDeleted { get; set; }

        public Guid? DeleteUserId { get; set; }

        public DateTime? DeletionTime { get; set; }
    }
}