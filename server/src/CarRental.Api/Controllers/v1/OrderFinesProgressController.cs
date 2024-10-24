using System;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
[Route("api/v{version:apiVersion}/Order/Progress/Fines/[action]")]
public class OrderFinesProgressController : CustomControllerBase
{
    private readonly ILogger<OrderFinesProgressController> _logger;
    public OrderFinesProgressController(ILogger<OrderFinesProgressController> logger){
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
