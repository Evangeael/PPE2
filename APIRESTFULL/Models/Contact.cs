using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIRESTFULL.Models
{
    public class Contact
    {
        private int id;
        private string nom;
        private string prenom;
        private string email;
        private string numero;
        private double latitude;
        private double longitude;
        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public double Latitude { get => latitude; set => latitude = value; }
        public double Longitude { get => longitude; set => longitude = value; }
    }
}