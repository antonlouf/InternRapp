﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;

namespace backend.Infrastructure.Persistence.Repositories;
public class SubDepartmentRepository : GenericRepository<SubDepartment>, ISubDepartmentRepository
{
    public SubDepartmentRepository(ApplicationDbContext context) 
                : base(context){}
}
