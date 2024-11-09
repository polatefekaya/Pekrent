using System;
using CarRental.Domain.DTO.Manager.Payment;

namespace CarRental.Application.Interfaces.Manager;

public interface IPaymentManager
{
    Task ChargeDownPayment(ChargePaymentDTO dto);
    Task ChargeDeposit(ChargePaymentDTO dto);
    Task ChargeLeftout(ChargePaymentDTO dto);
    Task RefundDeposit(RefundPaymentDTO dto);

}
