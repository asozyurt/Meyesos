
namespace Umbiad.App.DataAccess.Meyesos
{
    class MeyesosDataAccessManager : DataAccessManager
    {
        private MeyesosDBContainer container;
        public MeyesosDBContainer Container
        {
            get
            {
                return (container ?? new MeyesosDBContainer());
            }
            set
            {
                container = value;
            }
        }

        public override int SaveChanges()
        {
            return Container.SaveChanges();
        }

        public override void SaveChangesAsync()
        {
            Container.SaveChangesAsync();
        }
    }
}
