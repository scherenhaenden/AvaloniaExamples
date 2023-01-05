using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Calculator.Views.SubViews;

public partial class ProgrammerCalculatorView : UserControl
{
    public ProgrammerCalculatorView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}