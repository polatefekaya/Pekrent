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
    public async Task Login(){
    }

    [HttpPost]
    public async Task Register(){
    }

    [HttpGet]
    public async Task Logout(){
    }

    [HttpPost]
    public async Task SendTwoFactorAuth(){
        
    }

    [HttpPost]
    public async Task ManageTwoFactorVerification(){
        
    }

    [HttpPost]
    public async Task VerifyTwoFactorAuth(){
        
    }

    [HttpPost]
    public async Task SendConfirmationEmail(){
        
    }

    [HttpPost]
    public async Task ConfirmEmail(){
        
    }

    [HttpPost]
    public async Task ResetForgottenPassword(){
        
    }

    [HttpPost]
    public async Task ForgotPassword(){
        
    }

    [HttpPost]
    public async Task ChangePassword(){
        
    }
}
