﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace backend.Application.ApplicationUsers.Queries.GetApplicationUserByEmailContaining;
public class GetByEmailContainingQuery:IRequest<List<string>>
{
    public string EmailAdress { get; set; }
}
//Use different files for query and handler
public class GetByEmailContainingQueryHandler : IRequestHandler<GetByEmailContainingQuery, List<string>>
{
    private readonly IApplicationDbContext _dbContext;

    public GetByEmailContainingQueryHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<string>> Handle(GetByEmailContainingQuery request, CancellationToken cancellationToken)
    {
        //use a select to expose email. To much data is now fetched
        var users= await _dbContext.ApplicationUsers.Where(x => x.Email.StartsWith(request.EmailAdress)).ToListAsync();
        var emails=new List<string>();
        foreach (var user in users)
        {
            emails.Add(user.Email); 
        }
        return emails;
        
    }
}
