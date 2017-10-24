using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data;
using MvcApp.Models;
using MvcApp.Repostory;

namespace MvcApp.Repostory
{
    public class ClientRepository : IClientRepository, IDisposable
    {
        public ClientEntities1 context;
      
        public ClientRepository(ClientEntities1 _context)
        {
            this.context = _context;
        }
        public IEnumerable<Client> GetClients()
        {
            return context.Clients.ToList();
        }

        public Client GetClientByID(int id)
        {
            return context.Clients.SingleOrDefault(x =>x.Id==id);
        }

        public void InsertClient(Client _client)
        {
            context.Clients.Add(_client);
        }

        public void DeleteClient(int clientID)
        {
            Client _client = context.Clients.Find(clientID);
            context.Clients.Remove(_client);
        }

        public void UpdateClient(Client _client)
        {
            context.Entry(_client).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}