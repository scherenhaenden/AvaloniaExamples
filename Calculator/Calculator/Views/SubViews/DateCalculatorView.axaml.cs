using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Calculator.Views.SubViews;

public partial class DateCalculatorView : UserControl
{
    public DateCalculatorView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}