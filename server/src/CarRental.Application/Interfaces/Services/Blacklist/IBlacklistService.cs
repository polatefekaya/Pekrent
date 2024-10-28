using System;
using CarRental.Domain.Entities;

namespace CarRental.Application.Interfaces.Services.Blacklist;

public interface IBlacklistService : ICrudService<BlacklistEntity>
{
    Task SetDate(DateTime startDate, DateTime endDate);
    Task SetEndDate(DateTime endDate);
}
