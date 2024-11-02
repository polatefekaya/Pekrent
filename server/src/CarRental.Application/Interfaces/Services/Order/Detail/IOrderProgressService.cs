using System;
using CarRental.Domain.DTO.Order.Progress;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail;

public interface IOrderProgressService : ICrudService<OrderProgressEntity>
{
    Task SetOrderCreated(SetOrderCreatedDTO dto);
    Task SetActive(SetOrderActiveDTO dto);
    Task SetFinished(SetOrderFinishedDTO dto);
    Task SetStateCode(SetOrderStateCodeDTO dto);
}
