using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class Employee
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("ФИО")]
        public string FFP { get; set; }


        [DisplayName("Должность")]
        public string Post { get; set; }
    }
}
