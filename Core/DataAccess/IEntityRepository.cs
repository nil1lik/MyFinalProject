using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess
{
    //T:class => class olabilir değil referans tip olabilir demek
    public interface IEntityRepository<T> where T:class, IEntity, new()
	{
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //filtre verebilmeni ifade eder.
                                                                //filter = null filtre vermeyebilirsin
        T Get(Expression<Func<T, bool>> filter);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

