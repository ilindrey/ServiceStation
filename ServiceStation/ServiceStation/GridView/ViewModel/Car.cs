using System;
using System.ComponentModel;

namespace ServiceStation.GridView
{
    public class Car
    {
        [Browsable(false)]
        public Guid ID { get; set; }


        [DisplayName("Модель")]
        public string Model { get; set; }


        [DisplayName("VIN")]
        public string VIN { get; set; }


        [DisplayName("Пробег")]
        public decimal Mileage { get; set; }


        [DisplayName("Государственный номер")]
        public string LicensePlate { get; set; }

        
        [DisplayName("Год  выпуска")]
        public int? Year { get; set; }


        [DisplayName("Цвет")]
        public string Color { get; set; }
    }
}
