using System;
using CarRental.Application.Interfaces.Manager;
using CarRental.Domain.DTO.Manager.Progress;

namespace CarRental.Application.Manager;

public class ProgressManager : IProgressManager
{
    public Task ApprovePickUp(ApprovePickUpProgressDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task CreatePickUp(CreatePickUpProgressDTO dto)
    {
        throw new NotImplementedException();
    }

    public Task HandOver(HandOverProgressDTO dto)
    {
        throw new NotImplementedException();
    }
}
