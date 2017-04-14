using UIH.Mcsf.Viewer;

namespace ViewerControlAdapter
{
    /// <summary>
    /// Interaction logic for ViewerControlAdapter.xaml
    /// </summary>
    public partial class ViewerControlAdapter
    {
        public ViewerControlAdapter()
        {
            InitializeComponent();
            var viewerControl = new MedViewerControl();
            MainGrid.Children.Add(viewerControl);
        }
    }
}
