using System;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Order.Detail.Progress;

public interface IOrderTripProgressService : ICrudService<OrderTripProgressEntity>
{
    Task SetWaitingPickup(bool waiting);
    Task SetAuthenticated(bool authenticated);
    Task SetApproved(bool approved);
    Task SetInTrip(bool inTrip);
    Task SetReturned(bool returned);
}
