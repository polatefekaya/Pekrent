using System;
using CarRental.Application.Interfaces.Services.Save;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
public class SavingsController : CustomControllerBase
{
    private readonly ILogger<SavingsController> _logger;
    private readonly ISaveService _saveService;
    public SavingsController(ILogger<SavingsController> logger, ISaveService saveService){
        _logger = logger;
        _saveService = saveService;
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
