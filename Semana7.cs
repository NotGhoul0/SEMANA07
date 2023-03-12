// See https://aka.ms/new-console-template for more information
using System;

namespace TAREAsemana7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("EJERCICIO 1: ");

            

            int num;

            try
            {
                Console.WriteLine("INGRESE UN NUMERO ENTERO: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("RESULTADO: El numero es 0");
                }
                else if (num > 0)
                {
                    Console.WriteLine("RESULTADO: El numero es positivo");
                }
                else
                {
                    Console.WriteLine("RESULTADO: El numero es negativo");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("NO INGRESÓ UN NÚMERO: " + ex.Message);
            }

            
            Console.WriteLine("EJERCICIO NUMERO 2: ");

            
            int dia;

            Console.WriteLine("INGRESE UN NUMERO CORRESPONDIENTE AL DIA DE LA SEMANA (1 a 7): ");

            dia = Convert.ToInt32(Console.ReadLine());

            if (dia <= 0 || dia > 7)
            {
                Console.WriteLine("ERROR: EL NÚMERO A INGRESAR DEBE ESTAR CONTENIDO ENTRE 1 Y 7: ");
            }
            else
            {
                switch (dia)
                {
                    case 1:
                        Console.WriteLine("EL DIA ES LUNES: ");
                        break;

                    case 2:
                        Console.WriteLine("EL DIA ES MARTES: ");
                        break;

                    case 3:
                        Console.WriteLine("EL DIA ES MIERCOLES: ");
                        break;



                    case 4:
                        Console.WriteLine("EL DIA ES JUEVES: ");
                        break;

                    case 5:
                        Console.WriteLine("EL DIA ES VIERNES: ");
                        break;

                    case 6:
                        Console.WriteLine("EL DIA ES SABADO: ");
                        break;

                    case 7:
                        Console.WriteLine("EL DIA ES DOMINGO: ");
                        break;

                }

            }

            
            Console.WriteLine("TAREA: ");

            Console.WriteLine("INGRESE LA CANTIDAD DE DINERO: ");

            
            double dinero;
            int Q100, Q50, Q20, Q10, Q5, Q1, c25, c1;

            double M100, M50, M20, M10, M5, M1, Mc25, Mc1;

            dinero = Convert.ToDouble(Console.ReadLine());

            if (dinero < 0 || dinero > 9999.99)
            {
                Console.WriteLine("ERROR: LA CANTIDAD ES INVALIDA");
            }
            else
            {
                
                Q100 = (int)dinero / 100;
                M100 = Q100 * 100;
                dinero = dinero - M100;

                
                Q50 = (int)dinero / 50;
                M50 = Q50 * 50;
                dinero = dinero - M50;

                
                Q20 = (int)dinero / 20;
                M20 = Q20 * 20;
                dinero = dinero - M20;

                
                Q10 = (int)dinero / 10;
                M10 = Q10 * 10;
                dinero = dinero - M10;

                
                Q5 = (int)dinero / 5;
                M5 = Q5 * 5;
                dinero = dinero - M5;

                
                Q1 = (int)dinero / 1;
                M1 = Q1 * 1;
                dinero = dinero - M1;

             
                dinero = dinero * 100;
                c25 = ((int)dinero) / 25;
                Mc25 = c25 * 25;
                dinero = dinero - Mc25;

                if ((int)dinero == 0)
                {
                    c1 = 0;
                    Mc1 = 0;
                }
                else
                {
                    c1 = ((int)dinero / 1);
                    Mc1 = c1 * 1;
                    dinero = dinero - Mc1;
                }

                
                Console.WriteLine("LAS MONEDAS CORRESPONDIENTES SON: ");
                Console.WriteLine(Q100 + " BILLETES DE Q100");
                Console.WriteLine(Q50 + " BILLETES DE Q50");
                Console.WriteLine(Q20 + " BILLETES DE Q20");
                Console.WriteLine(Q10 + " BILLETES DE Q10");
                Console.WriteLine(Q5 + " BILLETES DE Q5");
                Console.WriteLine(Q1 + " BILLETES DE Q1");
                Console.WriteLine(c25 + " MONEDAS DE c25");
                Console.WriteLine(c1 + " MONEDAS DE c1");

            }






        }
    }

}
