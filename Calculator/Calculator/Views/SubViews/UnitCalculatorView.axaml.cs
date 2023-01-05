using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Calculator.Views.SubViews;

public partial class UnitCalculatorView : UserControl
{
    public UnitCalculatorView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}