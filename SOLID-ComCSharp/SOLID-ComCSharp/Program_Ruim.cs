using System;
using System.Collections.Generic;

public class Program_Ruim
{
    public static void Main(string[] args)
    {

    }

    //Ruim:
    void EmailClients(List<int> clients)
    {
        foreach (int client in clients)
        {
            var clientRecord = db.Find(client);
            if (clientRecord.IsActive())
            {
                Email(client);
            }
        }
    }

    private void Email(int client)
    {
        throw new NotImplementedException();
    }
}