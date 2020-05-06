using System;

namespace AreaFigureCalcLib
{
    /// <summary>
    /// Фигура треугольник
    /// </summary>
    public class TriangleFigure : BaseFigure
    {
        #region СТОРОНЫ ТРЕУГОЛЬНИКА

        #region PRIVATE
        private double sideA;
        private double sideB;
        private double sideC; 
        #endregion

        /// <summary>
        /// Сторона A
        /// </summary>
        public double SideA
        {
            get { return sideA; }
            set { sideA = Math.Abs(value); }
        }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double SideB
        {
            get { return sideB; }
            set { sideB = Math.Abs(value); }
        }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double SideC
        {
            get { return sideC; }
            set { sideC = Math.Abs(value); }
        }

        #endregion
        
        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTtriangle
        {
            get
            {
                if (sideA >= sideB && sideA >= sideC) { return sideA * sideA == (sideB * sideB + sideC * sideC); }
                if (sideB >= sideA && sideB >= sideC) { return sideB * sideB == (sideA * sideA + sideC * sideC); }
                if (sideC >= sideA && sideC >= sideB) { return sideC * sideC == (sideA * sideA + sideB * sideB); }

                return false;
            }
        }

        /// <summary>
        /// Нахождение площади треугольника
        /// </summary>
        /// <returns></returns>
        public override double GetArea()
        {
            // Нахождение полу периметра
            double p = (SideA + SideB + SideC) / 2;
            // Нахождение площади
            return Math.Sqrt(p * (p - this.SideA) * (p - this.SideB) * (p - this.SideC));
        }

        #region КОНСТРУКТОРЫ

        /// <summary>
        /// Создание новой фигуры: Треугольник
        /// </summary>
        /// <param name="name">Название фигуры Круг</param>
        /// <param name="sA">Сторона A</param>
        /// <param name="sB">Сторона B</param>
        /// <param name="sC">Сторона C</param>
        public TriangleFigure(double sA, double sB, double sC, string name = "Треугольник") : base(name)
        {
            this.SideA = sA;
            this.SideB = sB;
            this.SideC = sC;
        }

        /// <summary>
        /// Пустой конструктор Треугольника
        /// </summary>
        public TriangleFigure() : this(0, 0, 0) { }

        #endregion
    }
}
