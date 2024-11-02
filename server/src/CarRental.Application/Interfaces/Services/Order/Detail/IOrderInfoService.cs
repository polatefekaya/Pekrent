using System;
using CarRental.Domain.DTO.Order.Info;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail;

public interface IOrderInfoService : ICrudService<OrderInfoEntity>
{
    Task SetDates(SetInfoDatesDTO dto);
    Task SetState(SetInfoStateDTO dto);
    Task SetActive(SetInfoActiveDTO dto);
}
