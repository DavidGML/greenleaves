using System;
using System.Collections.Generic;

#nullable disable

namespace WS_green_leaves.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public string Ciudad { get; set; }
    }
}
