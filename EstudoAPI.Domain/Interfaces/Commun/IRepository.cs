﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EstudoAPI.Domain.Repositories
{
    public interface IRepository<TModel>
    {
        void Create(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        IQueryable<TModel> GetAll();
        TModel Get(Guid id);
        TModel GetBy(Expression<Func<TModel, bool>> predicate);
    }
}
