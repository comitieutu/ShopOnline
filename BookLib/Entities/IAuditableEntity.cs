﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Entities
{
    interface IAuditableEntity
    {
        DateTime CreatedDate { get; set; }
        //IdentityUser CreatedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        //IdentityUser ModifiedBy { get; set; }
    }
}
