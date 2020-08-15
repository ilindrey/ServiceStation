using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class Unit
    {
        [DisplayName("Код")]
        public int Code { get; set; }


        [DisplayName("Наименование")]
        public string Name { get; set; }


        [DisplayName("Сокращённое наименование")]
        public string ShortName { get; set; }
    }
}
