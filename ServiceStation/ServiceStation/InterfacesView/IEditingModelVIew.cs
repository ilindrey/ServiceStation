using System;

namespace ServiceStation.InterfacesView
{
    internal interface IEditingModelView : IEditingView
    {
        event Action SelectionMark;
        string NameMark { get; set; }
        string NameModel { get; }
        void SetModelInfo(string nameMark, string name);
    }
}
