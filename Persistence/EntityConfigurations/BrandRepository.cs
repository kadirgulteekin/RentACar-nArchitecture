﻿using Application.Services.Repositories;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class BrandRepository : EfRepositoryBase<Brand, Guid, BaseDbContext>,IBrandRepository
{
    public BrandRepository(BaseDbContext context) : base(context)  
    {

    }
}
