using System;
using CarRental.Application.Interfaces.Services.Order.Detail.Progress;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/Order/Progress/Fines/[action]")]
public class OrderFinesProgressController : CustomControllerBase
{
    private readonly ILogger<OrderFinesProgressController> _logger;
    private readonly IOrderFinesProgressService _orderFinesProgressService;
    public OrderFinesProgressController(ILogger<OrderFinesProgressController> logger, IOrderFinesProgressService orderFinesProgressService){
        _logger = logger;
        _orderFinesProgressService = orderFinesProgressService;
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
