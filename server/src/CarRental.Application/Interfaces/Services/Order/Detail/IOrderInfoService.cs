using System;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail;

public interface IOrderInfoService : ICrudService<OrderInfoEntity>
{
    Task SetDates(DateTime from, DateTime to);
    Task SetState(string state);
    Task SetActive(bool active);
}
