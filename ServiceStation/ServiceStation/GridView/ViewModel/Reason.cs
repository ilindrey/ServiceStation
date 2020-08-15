using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class Reason
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("Наименование")]
        public string ShortName {get;set;}


        [DisplayName("Полное наименование")]
        public string FullName { get; set; }


        [DisplayName("Тип проявления")]
        public string Type { get; set; }
    }
}
