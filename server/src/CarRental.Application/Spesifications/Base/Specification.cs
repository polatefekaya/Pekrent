using System;
using System.Linq.Expressions;
using CarRental.Application.Interfaces.Repository.Spesifications;

namespace CarRental.Application.Spesifications.Base;

public class Specification<T, TResult> : ISpecification<T, TResult>
{
    public Expression<Func<T, bool>>? Criteria { get; private set; }

    public List<Expression<Func<T, object>>> Includes { get; } = [];

    public Expression<Func<T, TResult>>? Selector { get; private set; }
    public Expression<Func<T, IEnumerable<TResult>>>? SelectorMany { get; private set; }

    public bool IsSingleResult { get; private set; } = false;
    public bool IsMany { get; private set; } = false;
    public Specification() { }

    public Specification(Expression<Func<T, bool>> criteria)
    {
        Criteria = criteria;
    }

    public void AddInclude(Expression<Func<T, object>> includeExpression)
    {
        Includes.Add(includeExpression);
    }

    public void ApplySelector(Expression<Func<T, TResult>> selector)
    {
        Selector = selector;
    }

    public void ApplySelectorMany(Expression<Func<T, IEnumerable<TResult>>> selectorMany){
        SelectorMany = selectorMany;
        IsMany = true;
    }

    public void ApplySingleResult()
    {
        IsSingleResult = true;
    }
}
