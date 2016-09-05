
using System;
using System.Data.Entity;
namespace Umbiad.App.DataAccess
{
    public class DataAccessManager
    {
        public DbContext DbContainer { get; set; }

        public int SaveChanges()
        {
            controlDbContext();
            return DbContainer.SaveChanges();
        }

        private void controlDbContext()
        {
            if (DbContainer == null)
                throw new Exception("DBContext is null");
        }

        public void SaveChangesAsync()
        {
            controlDbContext();
            DbContainer.SaveChangesAsync();
        }
    }
}
