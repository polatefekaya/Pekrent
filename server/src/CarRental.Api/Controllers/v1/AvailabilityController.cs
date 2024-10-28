using System;
using CarRental.Application.Interfaces.Services.Availability;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
public class AvailabilityController : CustomControllerBase
{
    private readonly ILogger<AvailabilityController> _logger;
    private readonly IAvailabilityService _availabilityService;
    public AvailabilityController(ILogger<AvailabilityController> logger, IAvailabilityService availabilityService){
        _logger = logger;
        _availabilityService = availabilityService;
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
    public async Task SetOnline(){
        
    }

    [HttpPut]
    public async Task SetLastOnline(){
        
    }

    [HttpPut]
    public async Task SetOnlineStates(){
        
    }

}
