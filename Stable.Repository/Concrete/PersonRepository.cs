﻿using Stable.Entity.Concrete;
using Stable.Repository.Abstract;
using Stable.Repository.Concrete.Context;
using Stable.Repository.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stable.Repository.Concrete
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public PersonRepository(StableDbContext stableDbContext) : base(stableDbContext)
        {
        }

    }
}