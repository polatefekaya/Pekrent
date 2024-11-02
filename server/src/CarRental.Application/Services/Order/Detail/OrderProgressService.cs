using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Order.Detail;
using CarRental.Domain.DTO.Order.Progress;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Order.Detail;

public class OrderProgressService : CrudService<OrderProgressEntity>, IOrderProgressService
{
    private readonly ILogger<OrderProgressService> _logger;
    private readonly IGenericRepository<OrderProgressEntity> _repository;
    public OrderProgressService(ILogger<OrderProgressService> logger, IGenericRepository<OrderProgressEntity> repository) : base(logger, repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public Task SetActive(SetOrderActiveDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetFinished(SetOrderFinishedDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetOrderCreated(SetOrderCreatedDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetStateCode(SetOrderStateCodeDTO dto)
    {
        throw new NotImplementedException();
    }
}
