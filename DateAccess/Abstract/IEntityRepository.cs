using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Abstract
{
    //generic constraint generic kısıt
    //class:referans tip
    //IEntity 
    //new():new'lenebilir olmalı
    public interface IEntityRepository<T>where T:class ,IEntity,new() 
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T Eentity);
        void Update(T entity);
        void Delete(T entity);

        List<T> GetAllByCategory(int categoryId);
    }
}
