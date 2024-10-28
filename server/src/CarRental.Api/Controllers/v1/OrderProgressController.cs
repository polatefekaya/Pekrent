using System;
using CarRental.Application.Interfaces.Services.Order.Detail;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/Order/Progress/[action]")]
public class OrderProgressController : CustomControllerBase
{
    private readonly ILogger<OrderProgressController> _logger;
    private readonly IOrderProgressService _orderProgressService;
    public OrderProgressController(ILogger<OrderProgressController> logger, IOrderProgressService orderProgressService){
        _logger = logger;
        _orderProgressService = orderProgressService;
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
