﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATS.Billing.Data.Interfaces
{
    public interface IRepository<TEntity> where TEntity: class
    {
        TEntity GetEntityOrDefault(Func<TEntity, bool> selector);
        void AddEntity(TEntity entity);

        bool RemoveEntity(TEntity entity);
        bool RemoveEntity(Func<TEntity, bool> selector);

        IEnumerable<TEntity> GetEntities(Func<TEntity, bool> selector);
        IEnumerable<TEntity> GetAllEntities();
        int Count { get; }
    }
}
