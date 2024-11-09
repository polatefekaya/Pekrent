using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Order.Fine;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Order.Fine;

public class OrderFineService : CrudService<OrderFineEntity>, IOrderFineService
{
    public OrderFineService(ILogger<OrderFineService> logger, IGenericRepository<OrderFineEntity> repository) : base(logger, repository)
    {
    }
}
