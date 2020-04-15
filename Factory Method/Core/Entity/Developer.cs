namespace Factory_Method
{
    /// <summary>
    /// Абстрактный класс строительной компании
    /// </summary>
    abstract class Developer
    {
        /// <summary>
        /// Наименование
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="n">Наименование</param>
        public Developer(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Фабричный метод
        /// </summary>
        /// <returns>Создаваемый объект типа <see cref="House"/></returns>
        abstract public House Create();
    }
}
