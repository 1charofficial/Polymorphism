using System;

namespace polymorphism
{

    





    class Program
    {
        static void Main(string[] args)
        {
            UserInput newUser = new UserInput();
            newUser.Converter("1", 50);
            newUser.Converter(true, 2.5m);
            newUser.Converter(12.2, 7.50000067897f);
            newUser.Converter("18", 193, "01.10.83", true);

            
            
        }
    }
}
