using System;
using CarRental.Domain.DTO.Order.Progress.Fines;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail.Progress;

public interface IOrderFinesProgressService : ICrudService<OrderFinesProgressEntity>
{
    Task SetChargedFineCount(SetChargedFineCountDTO dto);
    Task IncrementChargedFineCount(IncrementChargedFineCountDTO dto);
    Task SetChargedTotalAmount(SetChargedTotalAmountDTO dto);
    Task IncrementChargedTotalAmount(IncrementChargedTotalAmountDTO dto);
    Task SetFinesActive(SetFinesActiveDTO dto);
}
