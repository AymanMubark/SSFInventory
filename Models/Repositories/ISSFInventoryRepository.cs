using System.Collections.Generic;

namespace SSFInventory.Models.Repositories
{
    public interface ISSFInventoryRepository<TEntity>
    {
        IList<TEntity> List();
        TEntity Find(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
