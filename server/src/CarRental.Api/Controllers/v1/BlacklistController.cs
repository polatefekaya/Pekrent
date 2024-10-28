using System;
using CarRental.Application.Interfaces.Services.Blacklist;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
public class BlacklistController : CustomControllerBase
{
    private readonly ILogger<BlacklistController> _logger;
    private readonly IBlacklistService _blacklistService;
    public BlacklistController(ILogger<BlacklistController> logger, IBlacklistService blacklistService){
        _logger = logger;
        _blacklistService = blacklistService;
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
    public async Task SetDate(){
        
    }

    [HttpPut]
    public async Task SetEndDate(){
        
    }

}
