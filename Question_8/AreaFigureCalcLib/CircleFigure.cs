using System;

namespace AreaFigureCalcLib
{
    /// <summary>
    /// Фигура Круг
    /// </summary>
    public class CircleFigure : BaseFigure
    {
        #region PRIVATE FIELDS 
        private double radius;
        #endregion

        /// <summary>
        /// Радиус Круга
        /// </summary>
        public double Radius
        {
            get { return radius; }
            set { radius = Math.Abs(value); }
        }

        /// <summary>
        /// Получение площади Круга
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        #region КОНСТРУКТОРЫ
        
        /// <summary>
        /// Создание новой фигуры: Круг
        /// </summary>
        /// <param name="name">Название фигуры</param>
        /// <param name="radius">Радиус круга</param>
        public CircleFigure(double radius, string name = "Круг") : base(name)
        {
            this.Radius = radius;
        }

        /// <summary>
        /// Пустой конструктор Круга
        /// </summary>
        public CircleFigure() : this(0) { } 

        #endregion
    }
}
