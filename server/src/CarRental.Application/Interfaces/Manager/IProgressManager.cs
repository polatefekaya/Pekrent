using System;
using CarRental.Domain.DTO.Manager.Progress;

namespace CarRental.Application.Interfaces.Manager;

public interface IProgressManager
{
    Task CreatePickUp(CreatePickUpProgressDTO dto);
    Task ApprovePickUp(ApprovePickUpProgressDTO dto);
    Task HandOver(HandOverProgressDTO dto);
}
