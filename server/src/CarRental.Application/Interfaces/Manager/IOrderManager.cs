using System;
using CarRental.Domain.DTO.Manager.Order;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Manager;

public interface IOrderManager
{
    Task Start(StartOrderDTO<OrderEntity> dto);
    Task Cancel(CancelOrderDTO<OrderEntity> dto);
    Task Close(CloseOrderDTO<OrderEntity> dto);
}
