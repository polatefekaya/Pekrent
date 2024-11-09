using System;
using CarRental.Domain.DTO.Availablitiy;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Availability;

public interface IAvailabilityService : ICrudService<AvailabilityEntity>
{
    Task SetOnlineStates(SetOnlineStatesDTO dto);
}
