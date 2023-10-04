using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // class olmalı
    // IEntity  türünde  olmalı
    // new lenebilir olmalı  
    // public interface IEntityRepository<T> where T : struct // Değer tipler için 


    public interface IEntityRepository<T> where T : class,   IEntity,  new() 
    {
        List<T> GetAll(Expression<Func<T,bool >> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);

    }
}
