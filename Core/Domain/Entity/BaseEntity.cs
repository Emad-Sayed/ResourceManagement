﻿using Core.Domain.Entity.Access;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int? CreatedById { get; set; }
        public AppUser CreatedBy { get; set; }
        public int? UpdatedById { get; set; }
        public AppUser UpdatedBy { get; set; }
    }
}
