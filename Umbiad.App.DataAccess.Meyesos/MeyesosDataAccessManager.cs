
namespace Umbiad.App.DataAccess.Meyesos
{
    class MeyesosDataAccessManager : DataAccessManager
    {
        public MeyesosDBContainer Container
        {
            get
            {
                return ((MeyesosDBContainer)DbContainer ?? new MeyesosDBContainer());
            }
            set
            {
                DbContainer = value;
            }
        }
    }
}
