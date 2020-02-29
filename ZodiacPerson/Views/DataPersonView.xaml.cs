using System.Windows.Controls;
using ZodiacPerson.ViewModels;

namespace ZodiacPerson.Views
{
    /// <summary>
    /// Interaction logic for DataPersonView.xaml
    /// </summary>
    public partial class DataPersonView : UserControl
    {
        public DataPersonView()
        {
            InitializeComponent();
            DataContext = new DateViewModel();

        }
    }
}
