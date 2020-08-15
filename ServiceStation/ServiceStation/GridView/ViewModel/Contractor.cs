using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class Contractor
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("Наименование")]
        public string ShortName { get; set; }


        [DisplayName("Полное наименование")]
        public string FullName { get; set; }


        [DisplayName("ИНН")]
        public string INN { get; set; }


        [DisplayName("КПП")]
        public string KPP { get; set; }


        [DisplayName("ОКПО")]
        public string OKPO { get; set; }


        [DisplayName("E-mail")]
        public string Email { get; set; }


        [DisplayName("Телефон")]
        public string Phone { get; set; }
    }
}
