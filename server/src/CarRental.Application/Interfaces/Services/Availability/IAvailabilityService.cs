using System;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Availability;

public interface IAvailabilityService : ICrudService<AvailabilityEntity>
{
    Task SetOnline(bool online);
    Task SetLastOnline(DateTime lastOnline);
    Task SetOnlineStates(bool online, DateTime lastOnline);
}
