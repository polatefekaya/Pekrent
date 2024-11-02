using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Order.Detail;
using CarRental.Domain.DTO.Order.Auth;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Order.Detail;

public class OrderAuthService : CrudService<OrderAuthEntity>, IOrderAuthService
{
    private readonly ILogger<OrderAuthService> _logger;
    private readonly IGenericRepository<OrderAuthEntity> _repository;
    public OrderAuthService(ILogger<OrderAuthService> logger, IGenericRepository<OrderAuthEntity> repository) : base(logger, repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public Task SetCustomerToken(SetCustomerTokenDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetDealerToken(SetDealerTokenDTO dto)
    {
        throw new NotImplementedException();
    }
}
