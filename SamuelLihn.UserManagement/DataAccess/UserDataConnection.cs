using LinqToDB;
using LinqToDB.Configuration;
using LinqToDB.Data;
using SamuelLihn.UserManagement.Models;

namespace SamuelLihn.UserManagement.DataAccess
{
    public class UserDataConnection  : DataConnection
    {
        public ITable<User> Users => GetTable<User>();
        public ITable<Credential> Credentials => GetTable<Credential>();
        
        public UserDataConnection(LinqToDbConnectionOptions<UserDataConnection> options) : base(options)
        {
        }

    }
}
