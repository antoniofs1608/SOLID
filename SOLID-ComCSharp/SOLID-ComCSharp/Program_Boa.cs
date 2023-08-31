using System;
using System.Collections.Generic;
using System.Linq;

public class Program_Boa
{
    public static void Main(string[] args)
    {

    }

    // Bom:
    void EmailClients(List<int> clients)
    {
        var activeClients = ActiveClients(clients);
        activeClients.ForEach(Email);
    }

    List<int> ActiveClients(List<int> clients)
    {
        return clients.Where(IsClientActive).ToList();
    }

    bool IsClientActive(int client)
    {
        var clientRecord = db.Find(client);
        return clientRecord.IsActive();
    }

    private void Email(int client)
    {
        throw new NotImplementedException();
    }
}