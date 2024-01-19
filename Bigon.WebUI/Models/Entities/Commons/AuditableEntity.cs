﻿using System;
namespace Bigon.WebUI.Models.Entities.Commons
{
	public abstract class AuditableEntity
	{
        public int CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletedAt { get; set; }

        public int? LastModifiedBy { get; set; }

        public DateTime? LastModifiedAt { get; set; }
    }
}

