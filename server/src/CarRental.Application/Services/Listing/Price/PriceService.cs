using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Listing.Price;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Listing.Price;

public class PriceService : CrudService<PriceEntity>, IPriceService
{
    public PriceService(ILogger<PriceService> logger, IGenericRepository<PriceEntity> repository) : base(logger, repository)
    {
    }
}
