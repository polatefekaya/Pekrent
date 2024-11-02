using System;
using CarRental.Domain.DTO.Manager.Payment;

namespace CarRental.Application.Interfaces.Manager;

public interface IPaymentManager
{
    Task ChargeDownPayment(ChargeDownPaymentPaymentDTO dto);
    Task ChargeDeposit(ChargeDepositPaymentDTO dto);
    Task ChargeLeftout(ChargeLeftoutPaymentDTO dto);
    Task RefundDeposit(RefundDepositPaymentDTO dto);

}
