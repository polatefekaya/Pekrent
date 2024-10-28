using System;
using CarRental.Application.Interfaces.Services.Listing.Price;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
public class PriceController : CustomControllerBase
{
    private readonly ILogger<PriceController> _logger;
    private readonly IPriceService _priceService;
    public PriceController(ILogger<PriceController> logger, IPriceService priceService){
        _logger = logger;
        _priceService = priceService;
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
