using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Order.Detail.Progress;
using CarRental.Domain.DTO.Order.Progress.Trip;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Order.Detail.Progress;

public class OrderTripProgressService : CrudService<OrderTripProgressEntity>, IOrderTripProgressService
{
    private readonly ILogger<OrderTripProgressService> _logger;
    private readonly IGenericRepository<OrderTripProgressEntity> _repository;
    public OrderTripProgressService(ILogger<OrderTripProgressService> logger, IGenericRepository<OrderTripProgressEntity> repository) : base(logger, repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public Task SetApproved(SetApprovedPickUpDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetAuthenticated(SetAuthenticatedDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetInTrip(SetInTripDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetReturned(SetReturnedDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetWaitingPickup(SetWaitingPickUpDTO dto)
    {
        throw new NotImplementedException();
    }
}
