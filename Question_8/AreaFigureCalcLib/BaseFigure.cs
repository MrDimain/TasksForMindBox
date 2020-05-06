namespace AreaFigureCalcLib
{
    /// <summary>
    /// Абстрактный класс Фигуры, от которого будут наследоваться фигуры
    /// </summary>
    public abstract class BaseFigure
    {
        /// <summary>
        /// Название фигуры 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Метод для получение площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();

        /// <summary>
        /// Вывод фигуры
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Фигура: {this.Name}, Площадь: {this.GetArea():f2}";
        }

        /// <summary>
        /// Конструктор создания фигуры
        /// </summary>
        /// <param name="name"></param>
        public BaseFigure(string name)
        {
            this.Name = name;
        }
    }
}
