using System;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail.Progress;

public interface IOrderFinesProgressService : ICrudService<OrderFinesProgressEntity>
{
    Task SetChargedFineCount(int count);
    Task IncrementChargedFineCount();
    Task SetChargedTotalAmount(int amount);
    Task IncrementChargedTotalAmount(int extraIncrement);
    Task SetFinesActive(bool active);
}
