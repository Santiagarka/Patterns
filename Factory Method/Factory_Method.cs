using System;

namespace Factory_Method
{
    class Factory_Method
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("ООО ПанельСтрой");
            House housePanel = dev.Create();

            dev = new WoodDeveloper("Вася-плотник");
            House house = dev.Create();

            Console.ReadLine();
        }
    }
}