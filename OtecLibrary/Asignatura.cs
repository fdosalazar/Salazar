using System;
using System.Collections.Generic;
using System.Text;

namespace OtecLibrary
{
    public class Asignatura
    {
        private int id;
        private string nombre;
        //private List<Asignatura> listAsignatures;
        private List<Asignatura> asignaturas;

        public Asignatura()
        {

        }

        public Asignatura(List<Asignatura> asignaturas)
        {
            this.asignaturas = asignaturas;
        }

        public Asignatura(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
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
        public int ContadorAsignatura(List<Asignatura> asignatura)
        {
            int cont = 0;
            foreach (var item in asignatura)
            {
                cont++;
            }
            return cont;
        }
        public string DatosAsignatura()
        {
            return "Cantidad De Asignatura: " + ContadorAsignatura(asignaturas);
        }

    }
}
