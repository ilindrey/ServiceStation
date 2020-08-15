using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class OptionCustomer
    {
        [Browsable(false)]
        public Guid ID { get; set; }
        

        [DisplayName("Краткое наименование")]
        public string ShortName { get; set; }


        [DisplayName("Полное наименование")]
        public string FullName { get; set; }
    }
}
