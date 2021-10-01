using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MasterProject.service.Interface;
using MasterProject.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Web.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClient _client;

        public ClientController(IClient client)
        {
            _client = client;
        }
        public IActionResult Index()
        {
            IList<Client> data = _client.GetAll().Result.ToList<Client>();
            return View(data);
        }
    }
}