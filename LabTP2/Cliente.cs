using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTP2
{
    [Serializable]
    class Cliente
    {
        public Cliente(string n, int dni, string dir, string tel)
        {
            this.nombre = n;
            this.dni = dni;
            this.direccion = dir;
            this.telefono = tel;
        }

        private string nombre;
        public string Nombre { get { return nombre; } }

        private int dni;
        public int Dni { get { return dni; } }

        private string direccion;
        public string Direccion { get { return direccion; } }

        private string telefono;
        public string Telefono { get { return telefono; } }


    }
}
