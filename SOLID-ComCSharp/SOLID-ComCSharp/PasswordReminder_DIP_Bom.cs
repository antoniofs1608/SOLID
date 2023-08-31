using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_ComCSharp
{
    public class PasswordReminder_DIP_Bom
    {
        private MySQLConnection dbConnection;

        public void Construct_DIP_Bom(MySQLConnection dbConnection)
        {
            this.dbConnection = dbConnection;
        }

        // Faz alguma coisa
    }
}
