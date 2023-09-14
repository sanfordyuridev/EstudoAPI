using System.Linq.Expressions;

namespace EstudoAPI.Domain.Repositories
{
    public interface IRepository<TModel>
    {
        void Create(TModel model);
        void Update(TModel model);
        void Delete(TModel model);
        Task SalvarAlteracoes();
        IQueryable<TModel> GetAll();
        ValueTask<TModel> Get(Guid id);
        ValueTask<TModel> GetBy(Expression<Func<TModel, bool>> predicate);
    }
}
