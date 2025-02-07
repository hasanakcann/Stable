﻿using Stable.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stable.Entity.Concrete
{
    public class Address : EntityBase
    {
        public string Name { get; set; }
        public string AddressText { get; set; }
        public string Postcode { get; set; }
        public User User { get; set; }
        public long UserId { get; set; }
        public bool IsActiveAddress { get; set; }
    }
}
