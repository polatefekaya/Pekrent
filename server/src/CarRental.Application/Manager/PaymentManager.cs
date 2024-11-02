using System;
using CarRental.Application.Interfaces.Manager;
using CarRental.Domain.DTO.Manager.Payment;

namespace CarRental.Application.Manager;

public class PaymentManager : IPaymentManager
{
    public Task ChargeDeposit(ChargeDepositPaymentDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task ChargeDownPayment(ChargeDownPaymentPaymentDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task ChargeLeftout(ChargeLeftoutPaymentDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task RefundDeposit(RefundDepositPaymentDTO dto)
    {
        throw new NotImplementedException();
    }
}
