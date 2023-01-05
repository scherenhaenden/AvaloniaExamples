using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Calculator.ViewModels.SubViewModels;

namespace Calculator.Views.SubViews;

public partial class BasicCalculatorView : UserControl
{
    public BasicCalculatorView()
    {
        InitializeComponent();
        DataContext = new BasicCalculatorViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}