using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class Model
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("Модель")]
        public string Name { get; set; }


        [DisplayName("Марка")]
        public string Mark { get; set; }
    }
}
