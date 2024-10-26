using System;
using CarRental.Application.Interfaces.Services.Order.Detail.Progress;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/Order/Progress/Trip/[action]")]
public class OrderTripProgressController : CustomControllerBase
{
    private readonly ILogger<OrderTripProgressController> _logger;
    private readonly IOrderTripProgressService _orderTripProgressService;
    public OrderTripProgressController(ILogger<OrderTripProgressController> logger, IOrderTripProgressService orderTripProgressService){
        _logger = logger;
        _orderTripProgressService = orderTripProgressService;
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

    [HttpPut]
    public async Task SetWaitingPickupAsync(){
        
    }

    [HttpPut]
    public async Task SetAuthenticatedAsync(){
        
    }

    [HttpPut]
    public async Task SetApprovedAsync(){
        
    }

    [HttpPut]
    public async Task SetInTripAsync(){
        
    }

    [HttpPut]
    public async Task SetReturnedAsync(){
        
    }

}
