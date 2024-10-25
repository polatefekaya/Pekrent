using System;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail.Progress;

public interface IOrderPaymentProgressService : ICrudService<OrderPaymentProgressEntity>
{
    Task SetDownPaymentMade(bool paymentMade);
    Task SetDepositPaid(bool depositPaid);
    Task SetLeftoutCharged(bool charged);
}
