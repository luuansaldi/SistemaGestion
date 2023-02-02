using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13_Manipulando_datos_con_.NET
{
    internal class Venta
    {
        private long id;
        private string comentarios;
        private long idUser;

        public long Id { get => id; set => id = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public long IdUser { get => idUser; set => idUser = value; }
    }
}
