using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13_Manipulando_datos_con_.NET
{
    internal class Usuario
    {
        private long id;
        private string name;
        private string lastname;
        private string username;
        private string password;
        private string email;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
}
