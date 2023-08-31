using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_ComCSharp
{
    class PasswordReminder
    {
        private MySQLConnection dbConnection;

        public void Construct(DBConnectionInterface dbConnection)
        {
            this.dbConnection = (MySQLConnection)dbConnection;
        }
        // Faz alguma coisa
    }

    interface DBConnectionInterface
    {
        public void Connect();
    }

    public class MySQLConnection : DBConnectionInterface
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }
    }

    public class OracleConnection : DBConnectionInterface
    {
        public void Connect()
        {
            throw new NotImplementedException();
        }
    }
}
