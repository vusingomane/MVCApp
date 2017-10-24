using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MvcApp.Models;

namespace MvcApp.Repostory
{

    public interface IClientRepository : IDisposable
    {
        IEnumerable<Client> GetClients();
        Client GetClientByID(int clientId);
        void InsertClient(Client _Client);
        void DeleteClient(int clientID);
        void UpdateClient(Client _Client);
        void Save();
    }   
}