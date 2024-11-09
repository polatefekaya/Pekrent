using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Order.Detail.Progress;
using CarRental.Domain.DTO.Order.Progress.Fines;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Order.Detail.Progress;

public class OrderFinesProgressService : CrudService<OrderFinesProgressEntity>, IOrderFinesProgressService
{
    private readonly ILogger<OrderFinesProgressService> _logger;
    private readonly IGenericRepository<OrderFinesProgressEntity> _repository;
    public OrderFinesProgressService(ILogger<OrderFinesProgressService> logger, IGenericRepository<OrderFinesProgressEntity> repository) : base(logger, repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public Task IncrementChargedFineCount(IncrementChargedFineCountDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task IncrementChargedTotalAmount(IncrementChargedTotalAmountDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetChargedFineCount(SetChargedFineCountDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetChargedTotalAmount(SetChargedTotalAmountDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetFinesActive(SetFinesActiveDTO dto)
    {
        throw new NotImplementedException();
    }
}
