using System;
using System.Collections.Generic;
using System.Text;

namespace Excepciones
{
    internal class Test
    {
        public void division()
        {
            try
            {
                Console.WriteLine("Digite un numero");
                int numero = Convert.ToInt32(Console.ReadLine());
                decimal division = 25 / numero;
                Console.WriteLine(division);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void divisionMasEspecifico()
        {
            try
            {
                Console.WriteLine("Digite un numero");
                int numero = Convert.ToInt32(Console.ReadLine());
                decimal division = 25 / numero;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("El valor introducido no era un numero entero");
                Console.WriteLine(ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("No es posible dividir por 0");
                Console.WriteLine(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public void arreglo()
        {
            try
            {
                Console.WriteLine("Digite un numero");
                int posicion = Convert.ToInt32(Console.ReadLine());
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers);
                Console.WriteLine(myNumbers[posicion]);
            }

            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("El elemento no existe");
            }


            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine(e.Message);
            }
        }
    
        public void mayorEdad()
        {
            Console.WriteLine("Digite la edad de la persona");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                throw new ArithmeticException("Acceso denegado: debe tener al menos 18 años.");
            }
            else
            {
                Console.WriteLine("Acceso concedido - Tienes la edad suficiente!");
            }
        }


        public void agregarElementos()
        {
            Console.WriteLine("Digite el elemento a agregar");
            int numDig = Convert.ToInt32(Console.ReadLine());


            if(numDig == 5)
            {
                throw new AddElementException("No valido amigo");
            }


        }

    }

}
