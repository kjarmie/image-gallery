using LanguageExt;

namespace Core.Data.Contracts;

/// <summary>
/// This interface represents the contract of a repository for 'R' requests for a T entity.
/// </summary>
/// <typeparam name="T">The entity type</typeparam>
/// <typeparam name="TKey">The primary key type</typeparam>
public interface IQueryRepository<T, TKey> where T : notnull where TKey : notnull
{
   /// <summary>
   /// Asynchronously retrieves a single instance of T entity from the persistent store using the provided primary key.
   /// </summary>
   /// <param name="primaryKey">The primary key of the entity to retrieve.</param>
   /// <returns>A Task containing the Result of type T entity.</returns>
   Task<Fin<T>> ReadSingleAsync(TKey primaryKey);

   /// <summary>
   /// Retrieves a single instance of T entity from the persistent store using the provided primary key.
   /// </summary>
   /// <param name="primaryKey">The primary key of the entity to retrieve.</param>
   /// <returns>The Result of type T entity.</returns>
   Fin<T> ReadSingle(TKey primaryKey);

   /// <summary>
   /// Asynchronously retrieves a list of T entities from the persistent store.
   /// </summary>
   /// <returns>A Task containing the Result of an immutable list of T entities.</returns>
   Task<Fin<Seq<T>>> ReadAllAsync();

   /// <summary>
   /// Retrieves a list of T entities from the persistent store.
   /// </summary>
   /// <returns>The Result of an immutable list of T entities.</returns>
   Fin<Seq<T>> ReadAll();

   /// <summary>
   /// Asynchronously retrieves a list of T entities from the persistent store whose primary keys match those provided.
   /// </summary>
   /// <param name="primaryKeys">The list of primary keys to match against.</param>
   /// <returns>A Task containing the Result of an immutable list of T entities.</returns>
   Task<Fin<Seq<T>>> ReadAllAsync(Seq<TKey> primaryKeys);

   /// <summary>
   /// Retrieves a list of T entities from the persistent store whose primary keys match those provided.
   /// </summary>
   /// <param name="primaryKeys">The list of primary keys to match against.</param>
   /// <returns>The Result of an immutable list of T entities.</returns>
   Fin<Seq<T>> ReadAll(Seq<TKey> primaryKeys);

   /// <summary>
   /// Asynchronously applies the provided filter function on an IQueryable of T entities and returns the TResult. All
   /// error handling and mapping must be handled by the caller.
   /// </summary>
   /// <param name="filters">A function that takes an IQueryable of T entities and returns a TResult.</param>
   /// <returns>A Task containing the Result of the TOut after applying the filter function.</returns>
   Task<Fin<TOut>> ReadAllFilteredAsync<TOut>(Func<IQueryable<T>, Fin<TOut>> filters);

   /// <summary>
   /// Applies the provided filter function on an IQueryable of T entities and returns the TResult. All
   /// error handling and mapping must be handled by the caller.
   /// </summary>
   /// <param name="filters">A function that takes an IQueryable of T entities and returns a TResult.</param>
   /// <returns>The Result of the TOut after applying the filter function.</returns>
   Fin<TOut> ReadAllFiltered<TOut>(Func<IQueryable<T>, Fin<TOut>> filters);
}
