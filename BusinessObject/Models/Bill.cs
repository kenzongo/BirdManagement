﻿using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Bill
    {
        public Bill()
        {
            BillDescriptions = new HashSet<BillDescription>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime? DateCheckOut { get; set; }
        public double? Total { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual ICollection<BillDescription> BillDescriptions { get; set; }
    }
}