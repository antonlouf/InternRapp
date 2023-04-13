﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using backend.Application.Common.Interfaces;
using backend.Domain.Entities;
using MediatR;

namespace backend.Application.Languages.Commands.CreateLanguage;
public class CreateLanguageCommand:IRequest
{
    // make command immutable 
   public string Name { get; init; }
}
public class CreateLanguageCommandHandler : AsyncRequestHandler<CreateLanguageCommand>
{
    private readonly IApplicationDbContext _dbContext;

    public CreateLanguageCommandHandler(IApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    protected override  async Task Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
    {
        var entityTobeAdded = new Language() { Name = request.Name };
        await _dbContext.Languages.AddAsync(entityTobeAdded);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }
}
