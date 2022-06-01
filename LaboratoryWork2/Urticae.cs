using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratoryWork2
{
    /// <summary>
    /// Крапивница
    /// </summary>
    public class Urticae : Butterfly
    {
        public string PupalStage { get; set; }
        /// <summary>
        /// Период Активности
        /// </summary>
        public string TimeFly { get; set; }
        public Urticae() : base()
        {
            Eat = "листы крапивы";
            Color = "коричнево-бурая";
            Type = "Капустница";
            PupalStage = "2 недели";
            TimeFly = "с весны до осени";
        }
        /// <summary>
        /// Среда обитания
        /// </summary>
        /// <returns></returns>
        public static string LivingEnvironment()
        {
            return "\nШироко распространена в Европе, а также в Малой Азии, Средней Азии," +
                " Сибири, Китае, Монголии, Японии, Северном Вьетнаме и Корее. Встречается она повсюду в России," +
                " кроме Крайнего Севера, на Украине, в Балтии, в Белоруссии, в Молдавии, на Кавказе, в Закавказье," +
                " в Казахстане. Крапивница наблюдалась также на Камчатке, в Магаданской области и в Якутии\n";
        }

        public override string PrintValues()
        {
            return $"{base.PrintValues()},\nстадия куколки {PupalStage}, период активности: {TimeFly}";
        }

    }
}
