using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class Application
    {
        [DisplayName("Номер")]
        public int Number { get; set; }


        [DisplayName("Дата")]
        public DateTime Date { get; set; }


        [DisplayName("Контрагент")]
        public string Contractor { get; set; }


        [DisplayName("Автомобиль")]
        public string Car { get; set; }


        [DisplayName("Контактное лицо")]
        public string ContactPerson { get; set; }


        [DisplayName("Ответственное лицо")]
        public string Employee { get; set; }
    }
}
