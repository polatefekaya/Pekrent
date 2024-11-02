using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Order.Detail;
using CarRental.Domain.DTO.Order.Info;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Order.Detail;

public class OrderInfoService : CrudService<OrderInfoEntity>, IOrderInfoService
{
    private ILogger<OrderInfoService> _logger;
    private IGenericRepository<OrderInfoEntity> _repository;
    public OrderInfoService(ILogger<OrderInfoService> logger, IGenericRepository<OrderInfoEntity> repository) : base(logger, repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public Task SetActive(SetInfoActiveDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetDates(SetInfoDatesDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetState(SetInfoStateDTO dto)
    {
        throw new NotImplementedException();
    }
}
