using LanguageExt;

namespace Core.Data.Contracts;

/// <summary>
/// This class represents the contract of a repository for 'CUD' (Create, Update, Delete) operations for a T entity.
/// </summary>
public interface ICommandRepository<T, TKey> where T : notnull where TKey : notnull
{
   /// <summary>
   /// Asynchronously creates a single instance of T entity in the persistent store.
   /// </summary>
   /// <param name="entity">The instance of T entity to be created.</param>
   /// <returns>A Task containing the Result with the primary key of the created T entity.</returns>
   Task<Fin<TKey>> CreateSingleAsync(T entity);

   /// <summary>
   /// Creates a single instance of T entity in the persistent store.
   /// </summary>
   /// <param name="entity">The instance of T entity to be created.</param>
   /// <returns>The Result with the primary key of the created T entity.</returns>
   Fin<TKey> CreateSingle(T entity);

   /// <summary>
   /// Asynchronously creates a range of T entities in the persistent store.
   /// </summary>
   /// <param name="entities">The list of T entities to be created.</param>
   /// <returns>A Task representing the asynchronous operation.</returns>
   Task<Fin<Unit>> CreateRangeAsync(Seq<T> entities);

   /// <summary>
   /// Creates a range of T entities in the persistent store.
   /// </summary>
   /// <param name="entities">The list of T entities to be created.</param>
   /// <returns>The Result of the creation operation.</returns>
   Fin<Unit> CreateRange(Seq<T> entities);

   /// <summary>
   /// Asynchronously updates a single instance of T entity in the persistent store.
   /// </summary>
   /// <param name="entity">The instance of T entity to be updated.</param>
   /// <returns>A Task containing the Result of the updated T entity.</returns>
   Task<Fin<T>> UpdateSingleAsync(T entity);

   /// <summary>
   /// Updates a single instance of T entity in the persistent store.
   /// </summary>
   /// <param name="entity">The instance of T entity to be updated.</param>
   /// <returns>The Result of the updated T entity.</returns>
   Fin<T> UpdateSingle(T entity);

   /// <summary>
   /// Asynchronously updates a range of T entities in the persistent store.
   /// </summary>
   /// <param name="entities">The list of T entities to be updated.</param>
   /// <returns>A Task representing the asynchronous operation.</returns>
   Task<Fin<Unit>> UpdateRangeAsync(Seq<T> entities);

   /// <summary>
   /// Updates a range of T entities in the persistent store.
   /// </summary>
   /// <param name="entities">The list of T entities to be updated.</param>
   /// <returns>The Result of the update operation.</returns>
   Fin<Unit> UpdateRange(Seq<T> entities);

   /// <summary>
   /// Asynchronously deletes a single instance of T entity from the persistent store using its primary key.
   /// </summary>
   /// <param name="primaryKey">The primary key of the T entity to be deleted.</param>
   /// <returns>A Task representing the asynchronous operation.</returns>
   Task<Fin<Unit>> DeleteSingleAsync(TKey primaryKey);

   /// <summary>
   /// Deletes a single instance of T entity from the persistent store using its primary key.
   /// </summary>
   /// <param name="primaryKey">The primary key of the T entity to be deleted.</param>
   /// <returns>The Result of the delete operation.</returns>
   Fin<Unit> DeleteSingle(TKey primaryKey);
}
