using System.Windows.Controls;
using ZodiacPerson.Managers;
using ZodiacPerson.Tools;
using ZodiacPerson.ViewModels;

namespace ZodiacPerson
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : IContentWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var navigationModel = new NavigationModel(this);
            NavigationManager.Instance.Initialize(navigationModel);
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();
            DataContext = mainWindowViewModel;
            mainWindowViewModel.StartApplication();
        }

        public ContentControl ContentControl => _contentControl;
    }
}