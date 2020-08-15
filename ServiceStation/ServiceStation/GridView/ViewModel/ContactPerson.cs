using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class ContactPerson
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("ФИО")]
        public string FFP { get; set; }


        [DisplayName("E-mail")]
        public string Email { get; set; }


        [DisplayName("Телефон")]
        public string Phone { get; set; }
    }
}
