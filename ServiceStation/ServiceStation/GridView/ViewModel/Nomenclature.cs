using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStation.GridView
{
    public class Nomenclature
    {
        [DisplayName("Номер")]
        public int Number { get; set; }

        
        [DisplayName("Краткое наименование")]
        public string ShortName { get; set; }


        [DisplayName("Полное наименование")]
        public string FullName { get; set; }


        [DisplayName("Единица измерения")]
        public string Unit { get; set; }


        [DisplayName("Арктикул")]
        public string VendorCode { get; set; }

        
        [DisplayName("Тип")]
        public string Type { get; set; }
    }
}
