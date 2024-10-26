using System;
using CarRental.Application.Interfaces.Services.Order.Detail;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/Order/Info/[action]")]
public class OrderInfoController : CustomControllerBase
{
    private readonly ILogger<OrderInfoController> _logger;
    private readonly IOrderInfoService _orderInfoService;
    public OrderInfoController(ILogger<OrderInfoController> logger, IOrderInfoService orderInfoService){
        _logger = logger;
        _orderInfoService = orderInfoService;
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
