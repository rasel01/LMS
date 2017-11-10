using System.Data.Entity;
using System.Linq;
using LCLMS.Model;

namespace LCLMS.Repository
{
    public class BaseRepository<T> where T : Entity
    {
        protected BusinessDbContext db;
        public BaseRepository()
        {
            this.db = new BusinessDbContext();

        }


        public bool Add(T entity)
        {
            DbSet<T> dbSet = this.db.Set<T>();
            T add = dbSet.Add(entity);
            int i = this.db.SaveChanges();
            return i > 0;
        }
        public IQueryable<T> Get()
        {
            DbSet<T> dbSet = this.db.Set<T>();
            return dbSet.AsQueryable();

        }

        public T GetDetails(string id)
        {
            return this.db.Set<T>().Find(id);
        }

        public bool Edit(T entity)
        {
            this.db.Entry(entity).State = EntityState.Modified;
            int i = this.db.SaveChanges();
            return i > 0;
        }

        public bool Delete(string id)
        {
            var entity = GetDetails(id);
            if (entity != null)
            {
                this.db.Set<T>().Remove(entity);
                int i = this.db.SaveChanges();
                return i > 0;
            }

            return true;
        }




    }
}