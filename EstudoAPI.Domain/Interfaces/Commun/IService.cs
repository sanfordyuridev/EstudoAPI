namespace EstudoAPI.Domain.Interfaces.Commun
{
    public interface IService<TModel>
    {
        Task Create(TModel model);
        Task Update(TModel model);
        Task Delete(TModel model);
        IQueryable<TModel> GetAll();
        Task<TModel> Get(Guid id);
    }
}
