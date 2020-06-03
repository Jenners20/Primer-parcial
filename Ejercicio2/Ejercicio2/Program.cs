using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pedir al usuario el precio de
             * un producto y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta,
             * pedir el numero de tarjeta (12 digitos). Ojo, validar que el valor ingresado en el sea positivo.*/

            int precio = 0;
            int MetodoPago = 0;
            int Tarjeta = 0;
            Vuelve:
            Console.Write("Ingrese el precio de un producto: ");
            precio = int.Parse(Console.ReadLine());
            if (precio<=0)
            {
                Console.WriteLine("ERROR: EL PRECIO NO PUEDE SER NEGATIVO O IGUAL A CERO 0");
                Console.WriteLine("----> PULSE ENTER PARA VOLVER A INGRESAR EL PRECIO DE UN PRODUCTO...");
                Console.ReadKey();
                goto Vuelve;
            }
            Console.WriteLine();
            Vuelve1:
            Console.WriteLine("Menu para el Metodo de Pago ");
            Console.WriteLine();
            Console.WriteLine("(1)    Pagar en efectivo  ");
            Console.WriteLine();
            Console.WriteLine("(2)    Pagar con tarjeta ");
            Console.WriteLine();
            Console.WriteLine("(3)    Pagar con cheque  ");
            Console.WriteLine();
            Console.Write("Ingrese el número que está dentro del parentesis para seleccionar el metodo de pago:  ");
            MetodoPago = int.Parse(Console.ReadLine());
           
            switch (MetodoPago)
            {
                case 1:
                    Console.WriteLine("EFECTIVO es el metodo de pago seleccionado ");
                    Console.WriteLine("Debe de pagar un total de {0} en efectivo ", precio);
                    break;
                    case 2:
                    Vuelve2:
                    Console.WriteLine("TARJETA es el metodo de pago seleccionado ");
                    Console.Write("Ingrese el numero de su tarjeta: ");
                    Tarjeta = int.Parse(Console.ReadLine());
                    if (Tarjeta<=0)
                    {
                        Console.WriteLine("ERROR: EL NUMERO DE LA TARJETA NO PUEDE SER NEGATIVO O IGUAL A CERO 0");
                        Console.WriteLine("----> PULSE ENTER PARA VOLVER A INGRESAR EL NUMERO DE LA TARJETA...");
                        Console.ReadKey();
                        goto Vuelve2;
                    }
                    else
                    {
                        Console.WriteLine("El numero de su tarjeta es: {0} y fue ingresado satisfactoriamente ",Tarjeta);
                    }
                    break;
                case 3:
                    Console.WriteLine("CHEQUE es el metodo de pago seleccionado ");
                    Console.WriteLine("Debe de pagar un total de {0} en efectivo ", precio);
                    break;
                default:
                    Console.WriteLine("ERROR AL SELECCIONAR EL METODO DE PAGO");
                    Console.WriteLine("DEBE DE INGRESAR UN NUMERO ENTERO MAYOR QUE 0 Y MENOR O IGUAL A 3 ");
                    Console.WriteLine("----> PULSE ENTER PARA VOLVER A SELECCIONAR EL METODO DE PAGO ...");
                    Console.ReadKey();
                    goto Vuelve1;
                    break;
            }
            Console.ReadKey();
        }
    }
}
