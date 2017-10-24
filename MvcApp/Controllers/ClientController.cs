using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApp.Models;
using MvcApp.Repostory;
using PagedList;

namespace MvcApp.Controllers
{
    public class ClientController : Controller
    {
        private IClientRepository clientRepository;
        public ClientController()
        {
            this.clientRepository = new ClientRepository(new ClientEntities1());
        }

        public ViewResult Index()
        {
            var _client= clientRepository.GetClients();
            return View(_client);
        }

        public ActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClient(Client _client)
        {
            if (ModelState.IsValid)
            {
               clientRepository.InsertClient(_client);
               clientRepository.Save();
               return RedirectToAction("Index", "Client");
            }
            return View(_client);
        }


        public ActionResult EditClient(int ClientId)
        {
            if (TempData["Failed"] != null)
            {
                ViewBag.Failed = "Edit Client Failed";
            }
            Client _client = clientRepository.GetClientByID(ClientId);
            return View(_client);
        }

        [HttpPost]
        public ActionResult EditClient(Client _client)
        {            
            if (ModelState.IsValid)
            {
                clientRepository.UpdateClient(_client);
                clientRepository.Save();
                return RedirectToAction("Index", "Client");
            }
            return View(_client);
        }  
    }
}
