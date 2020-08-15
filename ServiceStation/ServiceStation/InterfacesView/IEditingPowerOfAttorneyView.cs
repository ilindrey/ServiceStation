using System;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingPowerOfAttorneyView : IEditingView
    {
        string Number { get; }
        DateTime Date { get; }
        void SetPowerOfAttorneyInfo(string number, DateTime date);
    }
}
