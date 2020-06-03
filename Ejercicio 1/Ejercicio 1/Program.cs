using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*Crear un programa que pida el nombre de un dia de la semana
             * e identifique si es fin de semana o no. En caso de error, indicarlo*/

            string dia ="";
            Vuelve:
            
                Console.Write("Ingrese un dia de la semana: ");
                dia = Console.ReadLine();
                            
           
            switch (dia)
            {
                case "Lunes": Console.WriteLine("El dia ingresado es Lunes y no es fin de semana ");
                      break;

                case "Martes":Console.WriteLine("El dia ingresado es Martes y no es fin de semana ");
                    break;

                case "Miercoles":Console.WriteLine("El dia ingresado es Miercoles y no es fin de semana ");
                    break;

                case "Jueves":Console.WriteLine("El dia ingresado es Jueves y no es fin de semana ");
                    break;

                case "Viernes": Console.WriteLine("El dia ingresado es Viernes y no es fin de semana ");
                    break;

                case "Sabado": Console.WriteLine("El dia ingresado es Sabado y es fin de semana ");
                    break;

                case "Domingo": Console.WriteLine("El dia ingresado es Domingo y es fin de semana ");
                    break;

                case "lunes":
                    Console.WriteLine("El dia ingresado es Lunes y no es fin de semana ");
                    break;

                case "martes":
                    Console.WriteLine("El dia ingresado es Martes y no es fin de semana ");
                    break;

                case "miercoles":
                    Console.WriteLine("El dia ingresado es Miercoles y no es fin de semana ");
                    break;

                case "jueves":
                    Console.WriteLine("El dia ingresado es Jueves y no es fin de semana ");
                    break;

                case "viernes":
                    Console.WriteLine("El dia ingresado es Viernes y no es fin de semana ");
                    break;

                case "sabado":
                    Console.WriteLine("El dia ingresado es Sabado y es fin de semana ");
                    break;

                case "domingo":
                    Console.WriteLine("El dia ingresado es Domingo y es fin de semana ");
                    break;

                default:Console.WriteLine("Uups. Al parecer hay un error, comprueba que ingresaste correctamente el día...");
                    Console.WriteLine();
                    Console.WriteLine("----> Pulse Enter para volver a ingresar el dia <----");
                    Console.ReadKey();
                    goto Vuelve;
                    break;
                        

            }

            Console.ReadKey();


        }
    }
}
