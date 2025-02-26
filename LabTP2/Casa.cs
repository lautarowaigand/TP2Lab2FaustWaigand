﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP2
{
    [Serializable]
    class Casa : Alojamiento
    {
        public Casa( int capacidad, string direccion, bool[] ser, int dMin) : base( capacidad, direccion)
        {
            this.servicios = ser;
            this.diasMinimos = dMin;

        }

        private bool[] servicios;
        public bool[] Servicios { get { return servicios; } set { servicios = value; } }

        private int diasMinimos;
        public int DiasMinimos { get { return diasMinimos; } set { diasMinimos = value; } }

        public override decimal PrecioPorDia()
        {
            return Trivago.precioBase * 2;
        }
    }
}