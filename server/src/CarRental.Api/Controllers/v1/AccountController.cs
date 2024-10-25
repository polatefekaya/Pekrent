using System;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
public class AccountController : CustomControllerBase
{
    private readonly ILogger<AccountController> _logger;

    public AccountController(ILogger<AccountController> logger){
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
