using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaciaUOM.Entidades
{
    public class RendionBono
    {
        public string Paciente { get; set; }
        public string NHCrendicion { get; set; }
        public string Medicamento { get; set; }
        public int cantDeInsumos { get; set; }
        public decimal Total { get; set; }
        public DateTime fechaPedido { get; set; }
    }
}
