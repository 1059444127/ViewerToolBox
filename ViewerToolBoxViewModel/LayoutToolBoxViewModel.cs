using System.Collections.ObjectModel;

namespace ViewerToolBoxViewModel
{
    class LayoutToolBoxViewModel : ViewerToolBoxViewModel
    {
        private readonly ObservableCollection<ToolViewModel> _tools;

        public LayoutToolBoxViewModel()
        {
            //TODO: LayoutToolBoxViewModel.Tools create from configure file using reflection
        }

        #region Overrides of ViewerToolBoxViewModel

        public override ObservableCollection<ToolViewModel> Tools { get { return _tools; } }

        #endregion
    }
}