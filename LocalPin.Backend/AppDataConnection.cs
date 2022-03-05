using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using LocalPin.Backend.Models;
using LocalPin.Shared.Models;

namespace LocalPin.Backend
{
    public class AppDataConnection : DataConnection
    {
        public ITable<PinPreview> Pins => GetTable<DbPinPreview>();
        public ITable<PinBody> PinBodies => GetTable<DbPinBody>();
        public ITable<PinType> PinTypes => GetTable<DbPinType>();
        public ITable<DbComment> Comments => GetTable<DbComment>();

        public AppDataConnection(LinqToDbConnectionOptions<AppDataConnection> options) : base(options)
        {
            
            
        }
    }
    

}