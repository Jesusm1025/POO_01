using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_01
{
    class mostrarVehiculo
    {
        static void Main(string[] args)
        {
            /*Crear también una clase llamada mostrarVehiculo. Esta clase 
            *deberá contener solo la función Main, que creara dos objetos de tipo 
            *Vehículo, les asignará una marca y un modelo y les pedirá verVehiculo.*/

            Vehiculo vehiculo1 = new Vehiculo();//objeto 1.
            vehiculo1.SetVehiculo("Ford", "Explore");//Asignacion de marca y modelo.
            vehiculo1.verVehiculo();//Mostrar valores.
            Console.WriteLine("");
            Vehiculo vehiculo2 = new Vehiculo();//Objeto 2.
            vehiculo2.SetVehiculo("Mazda", "Demio");//Asignacion de marca y modelo.
            vehiculo2.verVehiculo();//Mostrar valores.
            Console.ReadKey();
        }
    }
}
