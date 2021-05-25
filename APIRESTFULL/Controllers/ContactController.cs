using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIRESTFULL.Controllers
{
    public class ContactController : ApiController
    {
        [HttpPost]
        public bool AddContact()
        {
            return true;
        }
        [HttpGet]
        public string GetContact()
        {
            return "Martin Dupont";
        }
        [HttpDelete]
        public string DeleteContact(string id)
        {
            return "Contact supprimé id " + id;
        }
        [HttpPut]
        public string UpdateContact(string Name, String Id)
        {
            return "Mise à jour du contact avec le nom " + Name + " and Id " + Id;
        }

    }
}
