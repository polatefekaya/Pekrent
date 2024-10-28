using CarRental.Application.Interfaces.Services.Listing.Car;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
public class CarController : CustomControllerBase
{
    private readonly ILogger<CarController> _logger;
    private readonly ICarService _carService;
    public CarController(ILogger<CarController> logger, ICarService carService){
        _logger = logger;
        _carService = carService;
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
