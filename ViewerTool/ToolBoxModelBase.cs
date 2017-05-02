using System.Collections.Generic;
using System.ComponentModel.Composition;
using ViewerToolInterface;

namespace ViewerTool
{
    [InheritedExport]
    [Export(typeof(IToolBoxModel))]
    public abstract class ToolBoxModelBase : IToolBoxModel
    {
        [Export]
        private readonly IList<IViewDisplay> _viewDisplays = new List<IViewDisplay>();

        #region Implementation of IToolBoxModel

        public void Register(IViewDisplay viewDisplay)
        {
            _viewDisplays.Add(viewDisplay);
        }

        #endregion
    }
}