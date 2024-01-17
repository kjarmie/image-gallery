using Core.Domain.Entities;

namespace Core.Data.Contracts;

public interface IDbContext
{
    IQueryable<T> Set<T>() where T : class;
}