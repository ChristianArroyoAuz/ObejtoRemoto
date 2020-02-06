using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;


namespace Componente
{
    [Serializable]
    public class ClienteDetalle
    {
        [NonSerialized] private string password;
        private string nombre;
        private string email;
        private int id;

        public ClienteDetalle(int idCliente, string nombre, string password, string email)
        {
            ID = idCliente;
            Nombre = nombre;
            Email = email;
            Password = password;

        }

        public ClienteDetalle(string nombre, string password, string email)
        {
            Nombre = nombre;
            Password = password;
            Email = email;
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}