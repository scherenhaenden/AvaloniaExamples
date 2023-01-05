using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Calculator.Views.SubViews;

public partial class ScientificCalculatorView : UserControl
{
    public ScientificCalculatorView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}