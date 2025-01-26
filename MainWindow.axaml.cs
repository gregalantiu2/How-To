using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using How_To.Views;

namespace How_To
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            CurrentView = new HomeView();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public UserControl CurrentView { get; set; }

        private void HomeButton_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            CurrentView = new HomeView();
            var mainContent = this.FindControl<ContentControl>("MainContent");
            if (mainContent != null)
            {
                mainContent.Content = CurrentView;
            }
        }

        private void CreateHowToButton_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            CurrentView = new HowToView();
            var mainContent = this.FindControl<ContentControl>("MainContent");
            if (mainContent != null)
            {
                mainContent.Content = CurrentView;
            }
        }
    }
}