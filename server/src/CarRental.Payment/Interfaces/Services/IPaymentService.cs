using System;
using CarRental.Payment.Data.DTO;

namespace CarRental.Payment.Interfaces.Services;

public interface IPaymentService
{
    Task Charge(ChargeDTO dto);
    Task ReFund(RefundDTO dto);
}
