using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class Material
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("Материал")]
        public string Nomenclature { get; set; }


        [DisplayName("Количество")]
        public int Amount { get; set; }


        [DisplayName("Единица измерения")]
        public string Unit { get; set; }


        [DisplayName("Цена")]
        public decimal Price { get; set; }


        [DisplayName("Сумма")]
        public decimal Sum { get; set; }
    }
}
