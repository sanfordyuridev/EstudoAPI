using EstudoAPI.Domain.Entities;
using EstudoAPI.Domain.Repositories;
using EstudoAPI.Infra.Context;

namespace EstudoAPI.Repositories.Commun
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : Entity
    {
        protected readonly EstudoContext _context;

        public Repository(EstudoContext context) 
            => _context = context;
        

        public void Create(TModel model)
        {
            _context.Set<TModel>().Add(model); 
            _context.SaveChanges();
        }

        public void Update(TModel model)
        {
            _context.Set<TModel>().Update(model);
            _context.SaveChanges();
        }

        public void Delete(TModel model)
        {
            _context.Set<TModel>().Remove(model);
            _context.SaveChanges();
        }

        public TModel Get(int id) 
            => _context.Set<TModel>().Where(m => m.Id.Equals(id)).FirstOrDefault();
        

        public IQueryable<TModel> GetAll()
            => _context.Set<TModel>().AsQueryable();
    }
}
