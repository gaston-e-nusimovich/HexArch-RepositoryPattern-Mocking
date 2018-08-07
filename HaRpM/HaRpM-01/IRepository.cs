using System;

/// <summary>
/// Contract for Repositories. Entities that have repositories
/// must be both a class and said class must implement the contract IEntity.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T> where T : class, IEntity
{
       T FindBy(int id);
       IList<T> FindAll();
       void Add(T item);
       void Remove(T item);
       void Remove(int id);
       void Update(T item);
}
