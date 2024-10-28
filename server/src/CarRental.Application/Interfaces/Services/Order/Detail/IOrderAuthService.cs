using System;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail;

public interface IOrderAuthService : ICrudService<OrderAuthEntity>
{
    Task SetCustomerToken(string customerToken);
    Task SetDealerToken(string dealerToken);
}
