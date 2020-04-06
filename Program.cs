using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            string ope = "";
            List<string> listadeoperaciones = new List<string>();
            bool continua = true;

            do
            {

                ope = calculadora(ope);
                listadeoperaciones.Add(ope);
                continua = deseacontinuar();


            } while (continua == true);


            Console.WriteLine("Las operaciones ingresadas fueron: ");
            Console.WriteLine("");
            foreach (string dato in listadeoperaciones)
            {
                Console.WriteLine(dato);

            }

            Console.ReadLine();
        }

        public static string calculadora(string ope)
        {
            Console.WriteLine("Introduzca un numero");
            string numero1;
            numero1 = Console.ReadLine();
            if (Esnumero(numero1) == false)
            {
                Console.WriteLine("No es un numero");
                Console.ReadLine();
                return "Error";
            }

            Console.WriteLine("Introduzca un operador");
            string operador;
            operador = Console.ReadLine();

            if (Esoperador(operador) == false)
            {
                Console.WriteLine("No es un operador valido, solo acepta + o -");
                Console.ReadLine();
                return "Error";
            }
            Console.WriteLine("Introduzca un numero");
            string numero2;
            numero2 = Console.ReadLine();
            if (Esnumero(numero2) == false)
            {
                Console.WriteLine("No es un numero");
                Console.ReadLine();
                return "Error";
            }

            int resultado;

            if (operador == "+")
            {
                resultado = int.Parse(numero1) + int.Parse(numero2);
            }
            else
            {
                resultado = int.Parse(numero1) - int.Parse(numero2);
            }

            Console.WriteLine(numero1 + " " + operador + " " + numero2 + " = " + resultado);
            ope = numero1 + " " + operador + " " + numero2 + " = " + resultado;
            return ope;
        }

        public static bool Esnumero(string numero)
        {
            try
            {
                int num = int.Parse(numero);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool Esoperador(string operador)
        {
            if (operador == "+" || operador == "-")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool deseacontinuar()
        {
            string sigue;

            Console.WriteLine("Quiere continuar? Y / N");
            sigue = Console.ReadLine();
            if (sigue == "y" || sigue == "Y" || sigue == "n" || sigue == "N")
            {
                if (sigue == "y" || sigue == "Y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
              
            }
            else
            {
                Console.WriteLine("Respuesta ingresada errona, se permite Y / N");
                Console.ReadLine();
                return false;
            }
        }
    }
}
