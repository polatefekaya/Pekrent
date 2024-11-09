using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Listing;
using CarRental.Domain.DTO.Listing;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Listing;

public class ListingService : CrudService<ListingEntity>, IListingService
{

    private readonly ILogger<ListingService> _logger;
    private readonly IGenericRepository<ListingEntity> _repository;
    public ListingService(ILogger<ListingService> logger, IGenericRepository<ListingEntity> repository) : base(logger, repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public Task DecrementBookedCar(DecrementBookedCarDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task DecrementLeftCar(DecrementLeftCarDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task IncrementBookedCar(IncrementBookedCarDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task IncrementLeftCar(IncrementLeftCarDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetAllBooked(SetAllBookedDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetBookedCar(SetBookedCarDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetLeftCar(SetLeftCarDTO dto)
    {
        throw new NotImplementedException();
    }
}
