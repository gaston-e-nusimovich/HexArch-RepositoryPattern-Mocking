using System;

public interface IRepository<T> where T : class, IEntity
{
       T FindBy(int id);
       IList<T> FindAll();
       void Add(T item);
       void Remove(T item);
       void Remove(int id);
       void Update(T item);
}
