using System.Collections.Generic;
using System.Linq;

namespace SSFInventory.Models.Repositories
{
    public class CategoriesDbRepository : ISSFInventoryRepository<Categories>
    {
        SSFInventoryDbContext db;
        public CategoriesDbRepository(SSFInventoryDbContext _db)
        {
            db = _db;
        }
        public void Add(Categories entity)
        {
            db.Categories.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var category = Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
        }

        public Categories Find(int id)
        {
            var category = db.Categories.SingleOrDefault(c => c.Id == id);  
            return category;    
        }

        public IList<Categories> List()
        {
            return db.Categories.ToList();  
        }

        public void Update(int id, Categories NewCategory)
        {
            db.Update(NewCategory);
            db.SaveChanges();
        }
    }
}
