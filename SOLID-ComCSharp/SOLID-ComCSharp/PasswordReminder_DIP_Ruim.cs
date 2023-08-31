using System;
using System.Data.Common;
using Rhino.Mocks;
using static Rhino.Mocks.Delegates;

namespace SOLID_ComCSharp
{
    class PasswordReminder_DIP_Ruim
    {
        private MySQLConnection dbConnection;

        public void Construct_RUIM()
        {
            this.dbConnection = new MySQLConnection();
        }

         // Faz alguma coisa
    }
}
