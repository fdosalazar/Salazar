using System;
using System.Collections.Generic;
using OtecLibrary;

namespace Otec
{
    public class Program
    {
     
        static void Main(string[] args)
        {

            Sede La = new Sede(1,"Los Angeles");
            Console.WriteLine("Nombre Sede :" +La.Nombre);
            Encargado enc = new Encargado(1, "Fernando Salazar", "17.686.574-1", 987392538);
            Console.WriteLine("Nombre Encargado :" + enc.Nombre);
            Curso cu = new Curso(1, "Programacion");
            Console.WriteLine("Nombre curso :" + cu.Nombre);
            Asignatura a1 = new Asignatura(1, "Ingles");
            Asignatura a2 = new Asignatura(2, "NodeJS");
            Asignatura a3 = new Asignatura(3, "AngularJS");
            List<Asignatura> ListAsignaturas = new List<Asignatura>();
            ListAsignaturas.Add(a1);
            ListAsignaturas.Add(a2);
            ListAsignaturas.Add(a3);
            Asignatura asigx = new Asignatura(ListAsignaturas);
            Console.WriteLine(asigx.DatosAsignatura());
            Coordinador coo = new Coordinador(1, "Alberto Salazar", "11.111.111-1", 912345678);
            Console.WriteLine("Nombre Cordinador :" + coo.Nombre);
            Console.WriteLine("************************************");


            Sede Con = new Sede(1, "Concepcion");
            Console.WriteLine("Nombre Sede :" + Con.Nombre);
            Encargado enc2 = new Encargado(2, "Fernando Fernandez", "11.222.333-4", 987654321);
            Console.WriteLine("Nombre Encargado :" + enc2.Nombre);
            Curso cu2 = new Curso(2, "Cloud");
            Console.WriteLine("Nombre curso :" + cu2.Nombre);
            Asignatura a4 = new Asignatura(4, "Linux");
            Asignatura a5 = new Asignatura(5, "AWS");
            Asignatura a6 = new Asignatura(6, "GCP");
            Asignatura a7 = new Asignatura(7, "DevOps");
            List<Asignatura> ListAsignaturas2 = new List<Asignatura>();
            ListAsignaturas2.Add(a4);
            ListAsignaturas2.Add(a5);
            ListAsignaturas2.Add(a6);
            ListAsignaturas2.Add(a7);
            Asignatura asigx2 = new Asignatura(ListAsignaturas2);
            Console.WriteLine(asigx2.DatosAsignatura());
            Coordinador coo2 = new Coordinador(2, "Alberto Salazar", "11.111.111-1", 912345678);
            Console.WriteLine("Nombre Cordinador :" + coo2.Nombre);

            Console.WriteLine("************************************");

            Sede san = new Sede(3, "Santiago");
            Console.WriteLine("Nombre Sede :" + san.Nombre);
            Encargado enc3 = new Encargado(3, "William Wallace", "11.444.555-6", 9333334444);
            Console.WriteLine("Nombre Encargado :" + enc3.Nombre);
            Curso cu3 = new Curso(3, "Cajero");
            Console.WriteLine("Nombre curso :" + cu3.Nombre);
            Asignatura a8 = new Asignatura(8, "Lenguaje");
            Asignatura a9 = new Asignatura(9, "Matematicas");
            Asignatura a10 = new Asignatura(10, "Calculo");
            Asignatura a11 = new Asignatura(11, "Ingles");
            Asignatura a12 = new Asignatura(12, "Taller Conputacion");
            List<Asignatura> ListAsignaturas3 = new List<Asignatura>();
            ListAsignaturas3.Add(a8);
            ListAsignaturas3.Add(a9);
            ListAsignaturas3.Add(a10);
            ListAsignaturas3.Add(a11);
            ListAsignaturas3.Add(a12);
            Asignatura asigx3 = new Asignatura(ListAsignaturas3);
            Console.WriteLine(asigx3.DatosAsignatura());
            Coordinador coo3 = new Coordinador(3, "Alberto Salazar", "11.111.111-1", 911223344);
            Console.WriteLine("Nombre Cordinador :" + coo3.Nombre);

            Console.WriteLine("************************************");
        }

    }
}

