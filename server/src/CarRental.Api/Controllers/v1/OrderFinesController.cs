using System;
using CarRental.Application.Interfaces.Services.Order.Fine;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/Order/Fines/[action]")]
public class OrderFinesController : CustomControllerBase
{
    private readonly ILogger<OrderFinesController> _logger;
    private readonly IOrderFineService _orderFineService;
    public OrderFinesController(ILogger<OrderFinesController> logger, IOrderFineService orderFineService){
        _logger = logger;
        _orderFineService = orderFineService;
    }

    [HttpGet]
    public async Task GetAsync(){
    } 

    [HttpDelete]
    public async Task DeleteAsync(){
    }
    
    [HttpPost]
    public async Task AddAsync(){
    }

    [HttpPut]
    public async Task UpdateAsync(){
        
    }

}
