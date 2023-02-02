using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase13_Manipulando_datos_con_.NET
{
    internal class Producto
    {
        private long id;
        private string description;
        private decimal costo;
        private decimal precioVenta;
        private int stock;
        private long idUser;

        public long Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Stock { get => stock; set => stock = value; }
        public long IdUser { get => idUser; set => idUser = value; }
    }
}
