using System;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using ViewerToolInterface;

namespace ViewerToolBoxViewModel
{
    public class ToolViewModel : ViewModelBase
    {
        public ToolViewModel(IViewerTool tool)
        {
            _tool = tool;
            _tool.CanActChanged += ToolOnCanActChanged;
        }

        ~ToolViewModel()
        {
            _tool.CanActChanged -= ToolOnCanActChanged;
        }

        private void ToolOnCanActChanged(object sender, EventArgs eventArgs)
        {
            _toolCommand.RaiseCanExecuteChanged();
        }

        private readonly IViewerTool _tool;

        public string Name { get { return _tool.Name; } }

        #region [--ToolCommand--]

        private RelayCommand _toolCommand;

        public ICommand ToolCommand
        {
            get { return _toolCommand = _toolCommand ?? new RelayCommand(OnToolPicked, CanToolExecute); }
        }

        private bool CanToolExecute()
        {
            return _tool.CanAct;
        }

        private void OnToolPicked()
        {
            _tool.Act();;
        }

        #endregion [--ToolCommand--]    

    }
}