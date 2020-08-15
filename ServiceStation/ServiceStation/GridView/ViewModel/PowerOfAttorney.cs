using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class PowerOfAttorney
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("Номер")]
        public string Number { get; set; }


        [DisplayName("Дата")]
        public DateTime Date { get; set; }
    }
}
