using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcApp.Models;

namespace MvcApp.Models
{
    public class ClientInitializerDBData :DropCreateDatabaseIfModelChanges<ClientEntities1>
    {
        protected override void Seed(ClientEntities1 context)
        {
            var client = new List<Client>
            {
                new Client{ DateOfBirth= Convert.ToDateTime("1981-06-02"), FirstNames="Vusi Patrick", IdentityNumber="8106024884099", Surname="Ngomane"},
                new Client{ DateOfBirth= Convert.ToDateTime("1981-02-18"), FirstNames="Simon", IdentityNumber="8106025885099", Surname="Motaung"},
                new Client{ DateOfBirth= Convert.ToDateTime("1982-08-22"), FirstNames="Sifiso", IdentityNumber="8208223883099", Surname="Mkhize"}
            };

            foreach(var _client in client)
            {
                context.Clients.Add(_client);            
            }
            context.SaveChanges();
        }
    }
}