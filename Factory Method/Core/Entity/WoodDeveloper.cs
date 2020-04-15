namespace Factory_Method
{
    /// <summary>
    /// Строительная компания деревянных домов
    /// </summary>
    class WoodDeveloper : Developer
    {
        public WoodDeveloper(string name) : base(name)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
