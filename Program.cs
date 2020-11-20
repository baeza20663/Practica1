namespace Practica1
{
    class Program
    {

        public static void ManageAddMenu() // Controla Menú Sumas
        {
            while (true)
            {
                int counter = 1; // número que introducimos 1º 2º 3º
                int accumuled = 0; // acumulador de operaciones (sumas, etc)
                while (true) // No salimos hasta que metamos un Enter y 0) Salir
                {

                    UserInterface.ShowAddMenu(); // Mostrar texto Menú
                    string Message = "Introduce el " + counter + "º número: ";
                    int number = UserInterfaceUtils.ReadInteger(Message);
                    if (number == System.Int32.MinValue)
                    {
                        System.Console.WriteLine("El resultado es " + accumuled);
                        System.Console.WriteLine("");
                        break;
                    }
                    else accumuled += number; // si no es Enter acumulamos
                    counter++; // y sumamos uno al contador de entradas
                }
                UserInterface.ShowAddSubMenu();
                int option = UserInterface.ReadMenuOption();
                if (option == 0) return;

            }
        }
        public static void ManageMainMenu()
        {
            while (true)
            {
                UserInterface.ShowMainMenu();
                int option = UserInterface.ReadMenuOption();
                if (option == 0)
                {
                    break;
                }
                else if (option == -1)
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Opción Incorrecta");
                    System.Console.ReadLine();
                }
                else if ((option < 0 || option > 9))
                {
                    System.Console.Clear();
                    System.Console.WriteLine("Introduce una opción correcta 0-9");
                    System.Console.ReadLine();
                }
                else if (option == 1)
                {
                    ManageAddMenu();
                }
                System.Console.WriteLine("La opción es " + option);
            }
        }

        static void Main(string[] args)
        {
            ManageMainMenu();
        }
    }
}
