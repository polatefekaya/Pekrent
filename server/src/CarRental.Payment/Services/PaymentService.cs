using System;
using CarRental.Payment.Data.DTO;
using CarRental.Payment.Interfaces.Services;

namespace CarRental.Payment.Services;

public class PaymentService : IPaymentService
{
    public Task Charge(ChargeDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task ReFund(RefundDTO dto)
    {
        throw new NotImplementedException();
    }
}
