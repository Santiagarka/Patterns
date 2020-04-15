using System;

namespace Factory_Method
{
    /// <summary>
    /// Деревянный дом
    /// </summary>
    class WoodHouse : House
    {
        public WoodHouse()
        {
            Console.WriteLine("Деревянный дом построен");
        }
    }
}