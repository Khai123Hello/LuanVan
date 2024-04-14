using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class DBActions
    {
        public DBActions() { }

        public void Add<T>(T entity) where T : class
        {
            using (var context = new DBLuanVanEntities())
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete<T>(T entity) where T : class
        {
            using (var context = new DBLuanVanEntities())
            {
                context.Set<T>().Remove(entity);
                context.SaveChanges();
            }
        }

        public void Update<T>(T entity) where T : class
        {
            using (var context = new DBLuanVanEntities())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public List<T> GetAll<T>() where T : class
        {
            using (var context = new DBLuanVanEntities())
            {
                return context.Set<T>().ToList();
            }
        }
    }
}
