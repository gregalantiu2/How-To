using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace How_To.Views
{
    public partial class HowToView : UserControl
    {
        public HowToView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}