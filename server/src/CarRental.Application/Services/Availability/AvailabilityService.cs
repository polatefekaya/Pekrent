using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Availability;
using CarRental.Domain.DTO.Availablitiy;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Availability;

public class AvailabilityService : CrudService<AvailabilityEntity>, IAvailabilityService
{
    private readonly ILogger<AvailabilityService> _logger;
    private readonly IGenericRepository<AvailabilityEntity> _repository;
    public AvailabilityService(ILogger<AvailabilityService> logger, IGenericRepository<AvailabilityEntity> repository) : base(logger, repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public Task SetOnlineStates(SetOnlineStatesDTO dto)
    {
        throw new NotImplementedException();
    }
}
