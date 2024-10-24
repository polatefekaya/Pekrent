using System;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/Order/Progress/Payment/[action]")]
public class OrderPaymentProgressController : CustomControllerBase
{
    private readonly ILogger<OrderPaymentProgressController> _logger;
    public OrderPaymentProgressController(ILogger<OrderPaymentProgressController> logger){
        _logger = logger;
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
