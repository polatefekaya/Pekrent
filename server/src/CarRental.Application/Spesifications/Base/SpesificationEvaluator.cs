using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using CarRental.Application.Interfaces.Repository.Spesifications;

namespace CarRental.Application.Spesifications.Base;

public static class SpesificationEvaluator<T> where T : class
{
    public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, ISpesification<T> specification){
        IQueryable<T> query = inputQuery;

        if(specification.Criteria is not null){
            query = query.Where(specification.Criteria);
        }

        foreach(Expression<Func<T, object>> include in specification.Includes){
            query = query.Include(include);
        }

        return query;
    }
}
