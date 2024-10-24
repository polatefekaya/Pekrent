using System;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
public class BlacklistController : CustomControllerBase
{
    private readonly ILogger<BlacklistController> _logger;
    public BlacklistController(ILogger<BlacklistController> logger){
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
