namespace rest_api.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        Task<List<TEntity>> GetListAsync();
        Task InsertAsync(TEntity entity);
    }
}
