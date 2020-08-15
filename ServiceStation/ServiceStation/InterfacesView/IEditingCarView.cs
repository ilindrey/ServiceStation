using System;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingCarView : IEditingView
    {
        event Action SelectionModel;
        string NameModel { set; }
        string VIN { get; }
        decimal Mileage { get; }
        string LicensePlate { get; }
        string NumberEngine { get; }
        string NumberChassis { get; }
        string NumberBody { get; }
        DateTime Year { get; }
        string Color { get; }
        decimal Price { get; }
        void SetCarInfo(string nameModel, string VIN, decimal mileage, string licensePlate, string numberEngine,
                            string numberChassis, string numberBody, DateTime year, string color, decimal price);
    }
}
