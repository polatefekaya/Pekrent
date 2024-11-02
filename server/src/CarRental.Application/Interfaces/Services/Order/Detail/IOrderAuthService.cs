using System;
using CarRental.Domain.DTO.Order.Auth;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail;

public interface IOrderAuthService : ICrudService<OrderAuthEntity>
{
    Task SetCustomerToken(SetCustomerTokenDTO dto);
    Task SetDealerToken(SetDealerTokenDTO dto);
}
