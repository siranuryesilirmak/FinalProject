﻿
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class :referans tip
    //IEntity : IEntty olabilir veya IEntity i implemente eden bir nesne olabilir.
    //new() : new lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> Filter=null);
        T Get(Expression<Func<T, bool>> Filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       
    }
}
