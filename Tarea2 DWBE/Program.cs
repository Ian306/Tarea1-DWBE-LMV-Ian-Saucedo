﻿//Ian Mauricio Saucedo Aleman 
//Desarrollo Web Back-End LMV
using System;
using System.Linq;
using Tarea2_DWBE.DataAccess;

namespace Tarea2_DWBE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Primero creamos un data context para manipular nuestros modelos
            var DBContext = new NORTHWNDContext();
            //Entonces haremos un select mediante entity framework a las tablas
            //SELECT ContactName as Nombre, ContactTitle as Titulo, City as Ciudad 
            //From Customers WHERE City = 'México D.F.'
            var selectcostumersMexico = DBContext.Customers.Select(s => new
            {
                Nombre = s.ContactName,
                Titulo = s.ContactTitle,
                Ciudad = s.City
            }).Where(c => c.Ciudad == "México D.F.").AsQueryable().ToList();
            selectcostumersMexico.ForEach(costu => Console.WriteLine(costu.Nombre + 
            "\t|" + costu.Titulo + "\t|" + costu.Ciudad));
        }
    }
}
