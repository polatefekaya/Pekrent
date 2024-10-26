using System;
using CarRental.Application.Interfaces.Services.Listing;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
public class ListingController : CustomControllerBase
{
    private readonly ILogger<ListingController> _logger;
    private readonly IListingService _listingService;

    public ListingController(ILogger<ListingController> logger, IListingService listingService){
        _logger = logger;
        _listingService = listingService;
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
