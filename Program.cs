namespace Practica1
{
    class Program 
    {

        public static void ManageAddendumMenu() // Este Controlador sólo vale de EJEMPLO NO USAR. Controla Menú Sumas
        {
            while (true)
            {
                int counter = 1; // número que introducimos 1º 2º 3º
                int accumuled = 0; // acumulador de operaciones (sumas, etc)
                UserInterface.ShowAddMenu(); // Mostrar texto Menú
                while (true) // No salimos hasta que metamos un Enter y 0) Salir
                {

                    
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
                return;

            }
        }
        public static void ManagePow2Menu() // Controla Menú FACTORIAL
        {
            

                UserInterface.ShowPow2Menu(); // Mostrar texto Menú
                int acumulador1 = 1; int acumulador2 = 0; 


                    string Message = "Introduce el número:";
                    int number = UserInterfaceUtils.ReadInteger(Message);

                    for (int c = 0; c < number; c++)
                    {
                        acumulador2 = acumulador1 * 2;
                        acumulador1 = acumulador2;
                    }
                    System.Console.WriteLine("2 elevado a " + number + " es: " + acumulador1);
                System.Console.ReadLine();
        }
        public static void ManageAddMenu() // Controla Menú SUMA
        
        {
            UserInterface.ShowAddMenu(); // Mostrar texto Menú
            int counter = 1;
            string Message = "Introduce el número:";
            int number = UserInterfaceUtils.ReadInteger(Message);
            int acumulador1 = 0; int acumulador2 = 0;
            for (int c = 1; c < number + 1; c++)
            {
                acumulador2 = acumulador1 + c;
                acumulador1 = acumulador2;
            }
            System.Console.WriteLine("La suma de 1 hasta " + number + " es:" + acumulador1);
            System.Console.ReadLine();

        }
        public static void ManageFactorialMenu() // Controla Menú FACTORIAL
        {


            UserInterface.ShowFactorialMenu(); // Mostrar texto Menú

            string Message = "Introduce el número:";
            int number = UserInterfaceUtils.ReadInteger(Message);

            int fact = 1;

                for (int i = 1; i <= number; i++)
                {
                    fact *= i;
                }
                System.Console.WriteLine("\nEl Factorial de " + number + " es: " + fact);
                System.Console.ReadLine();
        }
        public static void ManagePrimeMenu() // Controla Menú PRIMO
        {
            string Message = "Introduce el número:";
            int number = UserInterfaceUtils.ReadInteger(Message);

            for (int i = 2; i < number; i++)
                {
                if ((number % i) == 0)
                {
                    // No es primo :(

                    System.Console.WriteLine("El número " + number + " NO es primo.");
                    i = number;
                }
                else
                {
                    System.Console.WriteLine("El número " + number + " ES PRIMO.");
                    i = number;
                }
            }
            System.Console.ReadLine();



        }
        public static void ManageFibonacciMenu() // Controla Menú FIBONACCI
        {
                int n1 = 0, n2 = 1, n3, i, number;
                System.Console.Write("Introduce el número: ");
                number = int.Parse(System.Console.ReadLine());
                System.Console.Write(n1 + " " + n2 + " "); //printing 0 and 1    
                for (i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
                {
                    n3 = n1 + n2;
                    System.Console.Write(n3 + " ");
                    n1 = n2;
                    n2 = n3;
                }
                System.Console.ReadLine();
            
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
                    else if (option == 2)
                    {
                        ManageAddMenu();
                    }
                    else if (option == 1)
                    {
                        ManagePow2Menu();
                    }
                    else if (option == 3)
                    {
                        ManageFactorialMenu();
                    }
                    else if (option == 4)
                    {
                        ManagePrimeMenu();
                    }
                    else if (option == 5)
                    {
                        ManageFibonacciMenu();
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
