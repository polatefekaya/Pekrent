using System;
using CarRental.Fines.Data.DTO;

namespace CarRental.Fines.Interfaces.Services;

public interface IFinesService
{
    Task Add(AddFineDTO dto);
    Task Delete(DeleteFineDTO dto);
    Task Update(UpdateFineDTO dto);
}
