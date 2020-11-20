namespace Practica1
{
    class UserInterfaceUtils
    {
        public static int ReadInteger(string Message)
        {
            while (true)
            {
                try
                {
                    System.Console.WriteLine(Message);
                    string line = System.Console.ReadLine();
                    if (line.Length == 0)
                    {
                        return System.Int32.MinValue;
                    }
                    int number = System.Convert.ToInt32(line);
                    return number;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine("Error");
                }
            }
        }
    }
}
