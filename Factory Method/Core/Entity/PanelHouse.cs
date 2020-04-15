using System;

namespace Factory_Method
{
    /// <summary>
    /// Панельный дом
    /// </summary>
    class PanelHouse : House
    {
        public PanelHouse()
        {
            Console.WriteLine("Панельный дом построен");
        }
    }
}
