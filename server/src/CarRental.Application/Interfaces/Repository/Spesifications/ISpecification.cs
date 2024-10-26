using System;
using System.Linq.Expressions;

namespace CarRental.Application.Interfaces.Repository.Spesifications;

public interface ISpecification<T, TResult>
{
    Expression<Func<T, bool>>? Criteria { get; }
    List<Expression<Func<T, object>>> Includes { get; }
    Expression<Func<T, TResult>>? Selector { get; }
    public Expression<Func<T, IEnumerable<TResult>>>? SelectorMany { get; }
    bool IsSingleResult { get; }
    bool IsMany { get; }

    public void AddInclude(Expression<Func<T, object>> includeExpression);
    public void ApplySelector(Expression<Func<T, TResult>> selector);
    public void ApplySelectorMany(Expression<Func<T, IEnumerable<TResult>>> selectorMany);
    public void ApplySingleResult();
}
