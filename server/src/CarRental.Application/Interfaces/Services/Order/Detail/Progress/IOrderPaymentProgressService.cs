using System;
using CarRental.Domain.DTO.Order.Progress.Payment;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail.Progress;

public interface IOrderPaymentProgressService : ICrudService<OrderPaymentProgressEntity>
{
    Task SetDownPaymentMade(SetDownPaymentMadeDTO dto);
    Task SetDepositPaid(SetDepositPaidDTO dto);
    Task SetLeftoutCharged(SetLeftoutChargedDTO dto);
}
