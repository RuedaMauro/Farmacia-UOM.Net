using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaciaUOM.Entidades
    {
    public class ListaInsumos
    {
        public int pedidoId { get; set; }
        public string cliente { get; set; }
        public string NHCpaciente { get; set; }
        public DateTime FechaPed { get; set; }
        public string pedUsuario { get; set; }

    }
}
