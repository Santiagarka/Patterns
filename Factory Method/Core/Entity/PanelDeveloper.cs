namespace Factory_Method
{
    /// <summary>
    /// Строительная компания панельных домов
    /// </summary>
    class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name)
        { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
