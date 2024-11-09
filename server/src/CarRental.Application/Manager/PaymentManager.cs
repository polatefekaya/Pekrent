using System;
using CarRental.Application.Interfaces.Manager;
using CarRental.Domain.DTO.Manager.Payment;
using CarRental.Payment.Data.DTO;
using CarRental.Payment.Interfaces.Services;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Manager;

public class PaymentManager : IPaymentManager
{
    private readonly ILogger<PaymentManager> _logger;
    private readonly IPaymentService _paymentService;

    private readonly string _className;

    public PaymentManager(ILogger<PaymentManager> logger, IPaymentService paymentService){
        _logger = logger;
        _paymentService = paymentService;

        _className = "PaymentManager";
    }
    public async Task ChargeDeposit(ChargePaymentDTO dto)
    {
        _logger.LogInformation("{methodName} in {className} is Started", nameof(ChargeDeposit), _className);

        ChargeDTO chargeDTO = new(){
            UserId = dto.UserId,
            Amount = dto.Amount,
            Description = dto.Description
        };

        await _paymentService.Charge(chargeDTO);
        
        _logger.LogDebug("{methodName} in {className} is Finished", nameof(ChargeDeposit), _className);
    }

    public async Task ChargeDownPayment(ChargePaymentDTO dto)
    {
        _logger.LogInformation("{methodName} in {className} is Started", nameof(ChargeDownPayment), _className);
        
        ChargeDTO chargeDTO = new(){
            UserId = dto.UserId,
            Amount = dto.Amount,
            Description = dto.Description
        };

        await _paymentService.Charge(chargeDTO);

        _logger.LogDebug("{methodName} in {className} is Finished", nameof(ChargeDownPayment), _className);
    }

    public async Task ChargeLeftout(ChargePaymentDTO dto)
    {
        _logger.LogInformation("{methodName} in {className} is Started", nameof(ChargeLeftout), _className);
        
        ChargeDTO chargeDTO = new(){
            UserId = dto.UserId,
            Amount = dto.Amount,
            Description = dto.Description
        };

        await _paymentService.Charge(chargeDTO);

        _logger.LogDebug("{methodName} in {className} is Finished", nameof(ChargeLeftout), _className);
    }

    public async Task RefundDeposit(RefundPaymentDTO dto)
    {
        _logger.LogInformation("{methodName} in {className} is Started", nameof(RefundDeposit), _className);
        
        RefundDTO refundDTO = new() {
            UserId = dto.UserId,
            ChargeId = dto.ChargeId,
            Description = dto.Description
        };

        await _paymentService.ReFund(refundDTO);

        _logger.LogDebug("{methodName} in {className} is Finished", nameof(RefundDeposit), _className);
    }
}
