using System;

namespace ViewerToolInterface
{
    public interface IViewerTool
    {
        string Name { get; }
        void Act();
        event EventHandler CanActChanged;
        bool CanAct { get; }
    }
}