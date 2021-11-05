using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class Encargado
    {
        private int id;
        private string nombre;
        private string rut;
        private int telefono;

        public Encargado()
        {

        }

        public Encargado(int id, string nombre, string rut, int telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.rut = rut;
            this.telefono = telefono;
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
