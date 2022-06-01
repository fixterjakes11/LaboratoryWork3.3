using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratoryWork2
{
    public class Butterfly
    {
        /// <summary>
        /// Виртуальный метод для вывода свойств
        /// </summary>
        public string Type { get;  set; }

        public string Color { get;  set; }
        public string Eat { get;  set; }
        /// Перегрузка конструкторов
        public Butterfly() {  }

        public Butterfly(string type)
        {
            Type = type;
        }

        public Butterfly(string type, string color)
        {
            Type = type;
            Color = color;
        }
        public Butterfly(string type, string color, string eat)
        {
            Type = type;
            Color = color;
            Eat = eat;
        }

        /// <summary>
        /// Виртуальный метод для вывода свойств
        /// </summary>
        /// <returns></returns>
        public virtual string PrintValues()
        {
            return $"Тип: {Type}, Цвет: {Color}, Еда: {Eat}";
        }
    }
}
