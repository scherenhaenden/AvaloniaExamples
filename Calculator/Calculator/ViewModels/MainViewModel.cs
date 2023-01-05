using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reactive;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Calculator.Views.SubViews;
using ReactiveUI;

namespace Calculator.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Header => "Welcome to Avalonia!";
    
    // Views CurrentView
    private UserControl _currentView;

    public UserControl CurrentView
    {
        get => _currentView;
        set => this.RaiseAndSetIfChanged(ref _currentView, value);
    }

    public MainViewModel()
    {
    
        CommandSwitchView= ReactiveCommand.Create<CalculatorType>(SwitchView);
    }
    
   
    public ReactiveCommand<CalculatorType, Unit> CommandSwitchView { get; }


    
    public ICommand Command { get; set; }
    
    // Enum calculator type 
   private CalculatorType _activeCalculatorType = CalculatorType.Basic;
   
    public CalculatorType ActiveCalculatorType
    {
        get => _activeCalculatorType;
        set => this.RaiseAndSetIfChanged(ref _activeCalculatorType, value);
    }
    
    public void ChangeViewOnClick(object sender, RoutedEventArgs e)
    {
        var menuItem = sender as MenuItem;
        var option = (CalculatorType)menuItem.Tag;
        SwitchView(option);
    }
    
    public MenuItem MenuOption
    {
        get
        {
            var vals = new MenuItem
            {
                Header = "Menu",
                Items = CalculatorTypeOptions,
                Tag = "Menu",
               
            };
            return vals;
        }
    }
    
    public List<MenuItem> CalculatorTypeOptions
    {
        get
        {
            return Enum.GetValues(typeof(CalculatorType))
                .Cast<CalculatorType>()
                .Select(x => new MenuItem
                {
                    Header = x.ToString(),
                    Tag = x,
                    Command = CommandSwitchView,
                    CommandParameter = x
                })
                .ToList();
        }
    }

    
    
    // method to switch between views
    public void SwitchView(CalculatorType calculatorType)
    {
        switch (calculatorType)
        {
            case CalculatorType.Basic:
                CurrentView = new BasicCalculatorView();
                break;
            case CalculatorType.Scientific:
                CurrentView = new ScientificCalculatorView();
                break;
            case CalculatorType.Programmer:
                CurrentView = new ProgrammerCalculatorView();
                break;
            case CalculatorType.Date:
                CurrentView = new DateCalculatorView();
                break;
            case CalculatorType.Unit:
                CurrentView = new UnitCalculatorView();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(calculatorType), calculatorType, null);
        }
    }
    
    // Menu
    
}

// Create enum for types of calculators
public enum CalculatorType
{
    Basic,
    Scientific,
    Programmer,
    Date,
    Unit
}

