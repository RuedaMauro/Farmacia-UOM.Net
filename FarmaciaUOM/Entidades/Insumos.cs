using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaciaUOM.Entidades
{
    public class Insumos
    {
        public string tipo_De_Insumo { get ; set; }
        public int id_Insumo {get; set;}
        public int cant { get; set; }
        public decimal precio { get; set; }
        public decimal subtotal { get; set; }
  
    }

    public class InsumosBonoRendicion
    {
        public int nroDeBono { get; set; }
        public string nPaciente { get; set; }
        public string NHC { get; set; }
        public DateTime fecha { get; set; }
        public string usuario { get; set; }
    }
}
