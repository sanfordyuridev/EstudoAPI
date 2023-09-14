using EstudoAPI.Domain.Entities;
using EstudoAPI.Domain.Repositories;
using EstudoAPI.Infra.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace EstudoAPI.Repositories.Commun
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : Entity
    {
        protected readonly EstudoContext _context;

        public Repository(EstudoContext context)
            => _context = context;

        public void Create(TModel model)
            => _context.Set<TModel>().Add(model);

        public void Update(TModel model)
            => _context.Set<TModel>().Update(model);

        public void Delete(TModel model)
            => _context.Set<TModel>().Remove(model);

        public ValueTask<TModel> Get(Guid id)
            => _context.Set<TModel>().FindAsync(id);

        public IQueryable<TModel> GetAll()
            => _context.Set<TModel>().AsQueryable();

        public ValueTask<TModel> GetBy(Expression<Func<TModel, bool>> predicate)
            => new ValueTask<TModel>(_context.Set<TModel>().Where(predicate).FirstOrDefaultAsync());

        public Task SalvarAlteracoes()
            => _context.SaveChangesAsync();
    }
}
