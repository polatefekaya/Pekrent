using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Order.Detail.Progress;
using CarRental.Domain.DTO.Order.Progress.Payment;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Order.Detail.Progress;

public class OrderPaymentProgressService : CrudService<OrderPaymentProgressEntity>, IOrderPaymentProgressService
{
    private readonly ILogger<OrderPaymentProgressService> _logger;
    private readonly IGenericRepository<OrderPaymentProgressEntity> _repository;
    public OrderPaymentProgressService(ILogger<OrderPaymentProgressService> logger, IGenericRepository<OrderPaymentProgressEntity> repository) : base(logger, repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public Task SetDepositPaid(SetDepositPaidDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetDownPaymentMade(SetDownPaymentMadeDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetLeftoutCharged(SetLeftoutChargedDTO dto)
    {
        throw new NotImplementedException();
    }
}
