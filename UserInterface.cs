namespace Practica1
{
    class UserInterface
    {
        public static void ShowMainMenu()
        {
            System.Console.Clear();
            System.Console.WriteLine("----------------");
            System.Console.WriteLine(" Menú principal ");
            System.Console.WriteLine("----------------");
            System.Console.WriteLine("1) Potencia en base 2");
            System.Console.WriteLine("2) Sumatorio de un número");
            System.Console.WriteLine("3) Calcular el factorial de un número");
            System.Console.WriteLine("4) Saber si un número de primo");
            System.Console.WriteLine("5) Imprimir la serie de Fibonacci");
            System.Console.WriteLine("0) Salir del programa");
        }
        
        public static void ShowPow2Menu()
        {
            // System.Console.BackgroundColor = System.ConsoleColor.Magenta;
            // System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine(" Potencia en base 2 ");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("Calcula 2 elevado a un número positivo");

        }
        public static void ShowAddMenu()
        {
            // System.Console.BackgroundColor = System.ConsoleColor.Magenta;
            // System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine(" Sumatorio de un número ");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("SUMA DE N números positivos");

        }
        public static void ShowFactorialMenu()
        {
            // System.Console.BackgroundColor = System.ConsoleColor.Magenta;
            // System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine(" Factorial de un número ");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("Calcula el Factorial de número");

        }
        public static void ShowPrimeMenu()
        {
            // System.Console.BackgroundColor = System.ConsoleColor.Magenta;
            // System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine(" Potencia en base 2 ");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("Calcula 2 elevado a un número positivo");

        }
        public static void ShowFibonacciMenu()
        {
            // System.Console.BackgroundColor = System.ConsoleColor.Magenta;
            // System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine(" Potencia en base 2 ");
            System.Console.WriteLine("------------------------");
            System.Console.WriteLine("Calcula 2 elevado a un número positivo");

        }
        public static void ShowAddSubMenu()
        {
            System.Console.WriteLine("Pulse ENTER para volver al Menú Principal");
            
        }
        public static int ReadMenuOption()
        {

            try
            {
                string option = System.Console.ReadLine();
                int selection = System.Convert.ToInt32(option);
                return selection;
            }
            catch (System.Exception e)
            {
                return -1;
                // rollback
            }
            finally
            {
                // Cerrar la conexión de las base de datos
            }

        }
    }
}
