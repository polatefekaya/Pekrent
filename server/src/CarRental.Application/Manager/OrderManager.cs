using System;
using CarRental.Application.Interfaces.Manager;
using CarRental.Application.Interfaces.Services.Order;
using CarRental.Domain.DTO;
using CarRental.Domain.DTO.Manager.Order;
using CarRental.Domain.Entities;
using CarRental.Payment.Interfaces.Services;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Manager;

public class OrderManager : IOrderManager
{
    private readonly ILogger<OrderManager> _logger;
    private readonly IPaymentService _paymentService;
    private readonly IOrderService _orderService;
    private readonly string _className;
    public OrderManager(ILogger<OrderManager> logger, IPaymentService paymentService, IOrderService orderService){
        _logger = logger;
        _paymentService = paymentService;
        _orderService = orderService;

        _className = "OrderManager";
    }

    public async Task Cancel(CancelOrderDTO<OrderEntity> dto)
    {
        _logger.LogInformation("{methodName} Order Process in {className}", nameof(Cancel), _className);
        UpdateGeneralDTO<OrderEntity> updateDto = new() {
            Entity = dto.Entity
        };
        await _orderService.UpdateAsync(updateDto);
    }

    public async Task Close(CloseOrderDTO<OrderEntity> dto)
    {
        _logger.LogInformation("{methodName} Order Process in {className}", nameof(Close), _className);

        UpdateGeneralDTO<OrderEntity> updateDto = new(){
            Entity = dto.Entity
        };

        await _orderService.UpdateAsync(updateDto);
    }

    public async Task Start(StartOrderDTO<OrderEntity> dto)
    {
        _logger.LogInformation("{methodName} Order Process in {className}", nameof(Start), _className);

        AddGeneralDTO<OrderEntity> addDto = new(){
            Entity = dto.Entity
        };

        await _orderService.CreateAsync(addDto);
    }
}
