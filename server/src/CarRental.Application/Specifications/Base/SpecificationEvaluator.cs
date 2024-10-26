using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using CarRental.Application.Interfaces.Repository.Spesifications;

namespace CarRental.Application.Specifications.Base;

public static class SpecificationEvaluator<T> where T : class
{
    public static IQueryable<TResult> GetQuery<TResult>(IQueryable<T> inputQuery, ISpecification<T, TResult> specification)
    {
        IQueryable<T> query = inputQuery;

        if (specification.Criteria is not null)
        {
            query = query.Where(specification.Criteria);
        }

        foreach (Expression<Func<T, object>> include in specification.Includes)
        {
            query = query.Include(include);
        }

        IQueryable<TResult> resultQuery;

        if (specification.IsMany && specification.SelectorMany is not null)
        {
            resultQuery = query.SelectMany(specification.SelectorMany);

        }
        else if (specification.Selector is not null)
        {
            resultQuery = query.Select(specification.Selector);

        }
        else
        {
            resultQuery = (IQueryable<TResult>)query;
        }

        if (specification.IsSingleResult)
        {
            resultQuery.Take(1);
        }

        return resultQuery;
    }
}