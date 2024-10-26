using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services;
using CarRental.Application.Interfaces.Services.Save;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Save;

public class SaveService : CrudService<SavedEntity>, ISaveService
{
    public SaveService(ILogger<SaveService> logger, IGenericRepository<SavedEntity> repository) : base(logger, repository)
    {
    }

   
}
