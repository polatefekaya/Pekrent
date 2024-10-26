using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository.Spesifications;

namespace CarRental.Application.Spesifications.Base;

public class Spesification<T> : ISpesification<T>
{
    public Expression<Func<T, bool>>? Criteria {get; private set;}

    public List<Expression<Func<T, object>>> Includes {get;} = [];

    public Spesification() {}

    public Spesification(Expression<Func<T, bool>> criteria){
        Criteria = criteria;
    }

    public void AddInclude(Expression<Func<T, object>> includeExpression){
        Includes.Add(includeExpression);
    }
}
