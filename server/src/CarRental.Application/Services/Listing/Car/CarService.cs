using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Listing.Car;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Listing.Car;

public class CarService : CrudService<CarEntity>, ICarService
{
    public CarService(ILogger<CarService> logger, IGenericRepository<CarEntity> repository) : base(logger, repository)
    {
    }
}
