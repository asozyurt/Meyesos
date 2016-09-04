
using System;
using System.Data.Entity;
namespace Umbiad.App.DataAccess
{
    public class DataAccessManager
    {
        private DbContext DbContainer;

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
