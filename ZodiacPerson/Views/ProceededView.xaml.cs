using System.Windows.Controls;
using ZodiacPerson.ViewModels;

namespace ZodiacPerson.Views
{
    /// <summary>
    /// Interaction logic for ProceededView.xaml
    /// </summary>
    public partial class ProceededView : UserControl
    {
        public ProceededView()
        {
            InitializeComponent();
            DataContext = new ProceedViewModel();
        }
    }
}
