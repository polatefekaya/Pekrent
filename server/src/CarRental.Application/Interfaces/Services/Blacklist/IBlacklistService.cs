using System;
using CarRental.Domain.DTO.Blacklist;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Blacklist;

public interface IBlacklistService : ICrudService<BlacklistEntity>
{
    Task SetDate(SetDateDTO dto);
    Task SetEndDate(SetEndDateDTO dto);
}
