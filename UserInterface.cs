namespace Practica1
{
    class UserInterface
    {
        public static void ShowMainMenu()
        {
            System.Console.Clear(); // no es ortodoxo pero de momento aquí
            System.Console.WriteLine("CONTA2");
            System.Console.WriteLine("------");
            System.Console.WriteLine("1) Realizar SUMAS de números");
            System.Console.WriteLine("2) Realizar RESTAS de números");
            System.Console.WriteLine("3) Realizar DIVISIÓN de números");
            System.Console.WriteLine("4) Realizar MULTIPLICACIÓN de números");
            System.Console.WriteLine("5) Realizar FACTORIAL de números");
            System.Console.WriteLine("6) Realizar ECUACION DE PRIMER GRADO");
            System.Console.WriteLine("7) Realizar ECUACION DE SEGUNDO GRADO");
            System.Console.WriteLine("0) SALIR DE LA APLICACIÓN");
        }
        public static void ShowAddMenu()
        {
            // System.Console.BackgroundColor = System.ConsoleColor.Magenta;
            // System.Console.ForegroundColor = System.ConsoleColor.White;
            System.Console.WriteLine("SUMA");
            System.Console.WriteLine("------");
        }
        public static void ShowAddSubMenu()
        {
            System.Console.WriteLine("1) REALIZAR OTRA SUMA");
            System.Console.WriteLine("0) SALIR DEL MENÚ");
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
