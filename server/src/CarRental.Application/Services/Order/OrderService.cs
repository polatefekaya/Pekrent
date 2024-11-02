using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Repository.Spesifications;
using CarRental.Application.Interfaces.Services.Order;
using CarRental.Domain.DTO;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Order;

public class OrderService : CrudService<OrderEntity>, IOrderService
{
    public OrderService(ILogger<OrderService> logger, IGenericRepository<OrderEntity> repository) : base(logger, repository){

    }
}
