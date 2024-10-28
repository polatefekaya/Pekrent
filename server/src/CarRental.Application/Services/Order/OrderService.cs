using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Services.Order;
using CarRental.Domain.Entities;

namespace CarRental.Application.Services.Order;

public class OrderService : IOrderService
{
    public Task CreateAsync(OrderEntity entity)
    {
        //After succesfull Order creation
        //Create a Order Progress
        //Create a Order Auth
        //Create a OrderInfo
        //after then, saveChanges
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task DeleteRangeAsync(int[] ids)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderEntity>?> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OrderEntity?> GetAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<OrderEntity?> GetFirstOrDefaultAsync(Expression<Func<OrderEntity, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<OrderEntity>?> GetRangeAsync(int[] ids)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(OrderEntity entity)
    {
        throw new NotImplementedException();
    }
}
