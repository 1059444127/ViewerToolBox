using System.Collections.ObjectModel;

namespace ViewerToolBoxViewModel
{
    public class ToolsToolBoxViewModel : ViewerToolBoxViewModel
    {
         
        private readonly ObservableCollection<ToolViewModel> _tools;

        public ToolsToolBoxViewModel()
        {
            //TODO: ToolsToolBoxViewModel.Tools create from configure file using reflection
        }

        #region Overrides of ViewerToolBoxViewModel

        public override ObservableCollection<ToolViewModel> Tools { get { return _tools; } }

        #endregion
    }
}