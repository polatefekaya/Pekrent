using System;
using CarRental.Domain.DTO.User;
using CarRental.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Api.Controllers.v1;

[ApiVersion("1.0")]
public class AccountController : CustomControllerBase
{
    private readonly ILogger<AccountController> _logger;
    private readonly UserManager<UserEntity> _userManager;
    private readonly SignInManager<UserEntity> _signInManager;

    public AccountController(ILogger<AccountController> logger, UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
    {
        _logger = logger;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet]
    public async Task GetAsync()
    {
    }

    [HttpDelete]
    public async Task DeleteAsync()
    {
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromBody] LoginUserDTO dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = await _userManager.FindByEmailAsync(dto.EMail!);
        if (user is null)
            return Unauthorized("Invalid login attempt.");

        var result = await _signInManager.PasswordSignInAsync(user, dto.Password!, true, false);
        if (!result.Succeeded)
            return Unauthorized("Invalid login attempt.");

        return Ok("Login successful!");
    }

    [HttpPost]
    public async Task<IActionResult> Register([FromBody] RegisterUserDTO dto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        UserEntity user = new UserEntity { UserName = dto.UserName, Email = dto.EMail };
        IdentityResult result = await _userManager.CreateAsync(user, dto.Password!);

        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok("Registered successfully!");
    }

    [HttpGet]
    public async Task<IActionResult> Logout()
    {
        await _signInManager.SignOutAsync();
        return Ok("Logout successful!");
    }

    [HttpPost]
    public async Task SendTwoFactorAuth()
    {

    }

    [HttpPost]
    public async Task ManageTwoFactorVerification()
    {

    }

    [HttpPost]
    public async Task VerifyTwoFactorAuth()
    {

    }

    [HttpPost]
    public async Task SendConfirmationEmail()
    {

    }

    [HttpPost]
    public async Task ConfirmEmail()
    {

    }

    [HttpPost]
    public async Task ResetForgottenPassword()
    {

    }

    [HttpPost]
    public async Task ForgotPassword()
    {

    }

    [HttpPost]
    public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDTO dto)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState);

        var user = await _userManager.FindByEmailAsync(dto.Email!);
        if (user is null)
            return NotFound("User not found.");

        var result = await _userManager.ChangePasswordAsync(user, dto.CurrentPassword!, dto.NewPassword!);
        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok("Password changed successfully!");
    }
}
