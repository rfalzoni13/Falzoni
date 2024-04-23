using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace Falzoni.Infra.Data.Context.MySql
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class FalzoniMySqlContext : FalzoniContext
    {
    }
}
