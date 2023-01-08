using System.Reactive;
using ReactiveUI;

namespace Calculator.ViewModels.AtomicViewModels;

public class CustomButtonViewModel: ViewModelBase
{
    // reactive command
    private ReactiveCommand<object, Unit> _command;
    public ReactiveCommand<object, Unit> GenericCommand
    {
        get => _command;
        set => this.RaiseAndSetIfChanged(ref _command, value);
    }
    
    // reactive AddOperatorCommand
    private ReactiveCommand<object, Unit> _addOperatorCommand;
    public ReactiveCommand<object, Unit> AddOperatorCommand
    {
        get => _addOperatorCommand;
        set => this.RaiseAndSetIfChanged(ref _addOperatorCommand, value);
    }
    
    // reactive string FontSizingNumber
    private string _fontSizingNumber;
    public string FontSizingNumber
    {
        get => _fontSizingNumber;
        set => this.RaiseAndSetIfChanged(ref _fontSizingNumber, value);
    }
    
    // reactive string ButtonSizingHeightNumber
    private string _buttonSizingHeightNumber = "200";
    public string ButtonSizingHeightNumber
    {
        get => _buttonSizingHeightNumber;
        set => this.RaiseAndSetIfChanged(ref _buttonSizingHeightNumber, value);
    }
    
    // reactive string ButtonSizingWidthNumber
    private string _buttonSizingWidthNumber = "200";
    public string ButtonSizingWidthNumber
    {
        get => _buttonSizingWidthNumber;
        set => this.RaiseAndSetIfChanged(ref _buttonSizingWidthNumber, value);
    }
    
    // reactive string ButtonSizingWidthNumberV2
    private string _buttonSizingWidthNumberV2 = "100";
    public string ButtonSizingWidthNumberV2
    {
        get => _buttonSizingWidthNumberV2;
        set => this.RaiseAndSetIfChanged(ref _buttonSizingWidthNumberV2, value);
    }
    
    // reactive object? CommandParameter
    private object? _commandParameter;
    public object? CommandParameter
    {
        get => _commandParameter;
        set => this.RaiseAndSetIfChanged(ref _commandParameter, value);
    }

    // reactive object? Content
    private object? _content = "not set";
    public object? Content
    {
        get => _content;
        set => this.RaiseAndSetIfChanged(ref _content, value);
    }
}