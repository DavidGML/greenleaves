using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WS_green_leaves.Models.Request
{
    public class Usuario_Request
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public string Ciudad { get; set; }
    }
}
