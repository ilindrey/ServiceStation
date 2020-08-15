using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class WorkingHour
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("Нормо-час")]
        public string Name { get; set; }

        
        [DisplayName("Наименование")]
        public decimal Price { get; set; }
    }
}
