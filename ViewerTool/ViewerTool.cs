using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using ViewerToolInterface;

namespace ViewerTool
{
    public abstract class ViewerTool : IViewerTool
    {
        #region Implementation of IViewerTool

        public abstract string Name { get; }

        public void Act()
        {
            foreach (var viewDisplay in ViewDisplays)
            {
                ActOn(viewDisplay);
            }
        }
        public event EventHandler CanActChanged = delegate {};
        public abstract bool CanAct { get; }

        #endregion

        #region [--Protected Template--]

        [Import]
        protected IList<IViewDisplay> ViewDisplays;

        protected void RaiseCanActChangedEvent()
        {
            CanActChanged(this, new EventArgs());
        }

        protected abstract void ActOn(IViewDisplay viewDisplay);

        #endregion
    }
}