using System;
using CarRental.Application.Interfaces.Services.Order.Detail;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/Order/Auth/[action]")]
public class OrderAuthController : CustomControllerBase
{
    private readonly ILogger<OrderAuthController> _logger;
    private readonly IOrderAuthService _orderAuthService;
    public OrderAuthController(ILogger<OrderAuthController> logger, IOrderAuthService orderAuthService){
        _logger = logger;
        _orderAuthService = orderAuthService;
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
