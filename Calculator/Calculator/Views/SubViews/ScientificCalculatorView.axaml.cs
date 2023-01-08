using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Calculator.ViewModels.SubViewModels;

namespace Calculator.Views.SubViews;

public partial class ScientificCalculatorView : UserControl
{
    public ScientificCalculatorView()
    {
        InitializeComponent();
        DataContext = new ScientificCalculatorViewModel();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}