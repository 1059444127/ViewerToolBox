using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;

namespace ViewerToolBoxViewModel
{
    public abstract class ViewerToolBoxViewModel : ViewModelBase
    {
         public abstract ObservableCollection<ToolViewModel> Tools { get; } 
    }
}