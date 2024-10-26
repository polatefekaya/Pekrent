using System;
using System.Linq.Expressions;

namespace CarRental.Application.Interfaces.Repository.Spesifications;

public interface ISpesification<T>
{
    Expression<Func<T, bool>>? Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }
}
