using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class ReasonCustomer
    {
        [Browsable(false)]
        public Guid ID { get; set; }

        
        [DisplayName("Краткое наименование")]
        public string ShortName { get; set; }


        [DisplayName("Полное наименование")]
        public string FullName { get; set; }

        
        [DisplayName("Тип проявления")]
        public string Type { get; set; }


        [DisplayName("Цена услуги")]
        public decimal? Price { get; set; }
    }
}
