using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class Work
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("Работа")]
        public string Nomenclature { get; set; }


        [DisplayName("Количество")]
        public int Amount { get; set; }


        [DisplayName("Нормо-час")]
        public string WorkingHour { get; set; }

        
        [DisplayName("Цена нормо-часа")]
        public decimal PriceWorkingHour { get; set; }


        [DisplayName("Норма времени")]
        public decimal NormOfTime { get; set; }


        [DisplayName("Сумма")]
        public decimal? Sum { get; set; }
    }
}
