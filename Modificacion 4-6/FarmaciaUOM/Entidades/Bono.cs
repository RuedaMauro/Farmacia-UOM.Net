﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FarmaciaUOM.Entidades
{

    public class Bono
    {
        public Bono(){}
        
        public long Nro_Bono { get; set; }
        public DateTime Fecha { get; set; }
        public string Paciente{ get; set; }
        public long Documento { get; set; }
        public string NHC { get; set; }
        public string Seccional { get; set; }
        public DateTime F_Nac { get; set; }
        public string Medico { get; set; }
        public string Autorizante { get; set; }
        public string Usuario { get; set; }
        public string RazonSocial { get; set; }
        public string Calle { get; set; }
        public string Nro { get; set; }
        public string Localidad { get; set; }
        public string Especialidad { get; set; }
        public decimal Total { get; set; }
        public string Cancelado { get; set; }
        public string Gente_Foto { get; set; }
        public string Monotributo { get; set; }

        public class BonoPase
        { 
            public int Documento {get;set;}
            public int AutorizanteId {get;set;}
            public Int32 Usuario {get;set;}
            public int AutorizaBono {get;set;}
            public int AutorizaMotivo {get;set;}
            public string Observaciones { get; set; }
            public string TipoOrden { get; set; }
            public string accion { get; set; }
            public string Monto { get; set; }
            public string comentario { get; set; }
    
        }
    }

    
}
