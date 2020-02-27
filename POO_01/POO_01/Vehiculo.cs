using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_01
{
    /*Crear una clase llamada Vehículo, esta debe tener los siguientes
     *atributos: Marca y Modelo. También crear los métodos SetVehiculo, 
     *de tipo void y con los parámetros string, que permita cambiar el 
     *valor de la marca y del modelo. También debe crear un método verVehiculo, 
     *que muestre en pantalla “El vehículo es: “, seguido de los datos recibidos 
     *por el método.*/
    class Vehiculo
    {
        //Agregamos los atributos de la clase.
        public string marca;
        public string modelo;
        public Vehiculo()
        {
            //Los constructores de los atributos o de clase.
            marca = "";
            modelo = "";
        }
        public void SetVehiculo(string marca, string modelo)
        {
            //Metodo que permite cambiar los valores de los atributos.
            this.marca = marca;
            this.modelo = modelo;
        }
        public void verVehiculo()
        {
            //Metodo que muestra en pantalla los valores de la clase.
            Console.WriteLine("El vehiculo es: " + marca +" " + modelo);
        }
    }
}
