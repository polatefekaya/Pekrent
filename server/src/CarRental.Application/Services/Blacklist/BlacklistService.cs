using System;
using CarRental.Application.Interfaces.Repository;
using CarRental.Application.Interfaces.Services.Blacklist;
using CarRental.Domain.DTO.Blacklist;
using CarRental.Domain.Entities;
using Microsoft.Extensions.Logging;

namespace CarRental.Application.Services.Blacklist;

public class BlacklistService : CrudService<BlacklistEntity>, IBlacklistService
{
    private readonly ILogger<BlacklistService> _logger;
    private readonly IGenericRepository<BlacklistEntity> _repository;
    public BlacklistService(ILogger<BlacklistService> logger, IGenericRepository<BlacklistEntity> repository) : base(logger, repository)
    {
        _logger = logger;
        _repository = repository;
    }

    public Task SetDate(SetDateDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task SetEndDate(SetEndDateDTO dto)
    {
        throw new NotImplementedException();
    }
}
