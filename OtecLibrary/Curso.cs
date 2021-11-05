using System;
using System.Collections.Generic;
using System.Text;




namespace OtecLibrary
{
    public class Curso
    {
        private int id;
        private string nombre;

        public Curso()
        {

        }

        public Curso(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Iid
        {
            get { return id; }
            set { id = value; }
        }
       
    }
}
