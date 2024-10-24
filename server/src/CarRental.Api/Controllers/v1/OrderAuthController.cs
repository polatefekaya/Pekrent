using System;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/Order/Auth/[action]")]
public class OrderAuthController : CustomControllerBase
{
    private readonly ILogger<OrderAuthController> _logger;
    public OrderAuthController(ILogger<OrderAuthController> logger){
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
