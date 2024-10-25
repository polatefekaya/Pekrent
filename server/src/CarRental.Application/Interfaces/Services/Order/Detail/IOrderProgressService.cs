using System;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail;

public interface IOrderProgressService : ICrudService<OrderProgressEntity>
{
    Task SetOrderCreated(bool created);
    Task SetActive(bool active);
    Task SetFinished(bool finished);
    Task SetStateCode(int code);
}
