namespace Calculator.ViewModels.SubViewModels;

public class ScientificCalculatorViewModel: ViewModelBase
{
    public ScientificCalculatorViewModel()
    {
    }
    
    public BasicCalculatorViewModel BasicDataContext { get; set; } = new BasicCalculatorViewModel();
    // Add commands
        /*Commands.Add(new CommandViewModel("Sin", new RelayCommand(param => this.Sin())));
        Commands.Add(new CommandViewModel("Cos", new RelayCommand(param => this.Cos())));
        Commands.Add(new CommandViewModel("Tan", new RelayCommand(param => this.Tan())));
        Commands.Add(new CommandViewModel("Log", new RelayCommand(param => this.Log())));
        Commands.Add(new CommandViewModel("Ln", new RelayCommand(param => this.Ln())));
        Commands.Add(new CommandViewModel("Sqrt", new RelayCommand(param => this.Sqrt())));
        Commands.Add(new CommandViewModel("Pow", new RelayCommand(param => this.Pow())));
        Commands.Add(new CommandViewModel("Exp", new RelayCommand(param => this.Exp())));
        Commands.Add(new CommandViewModel("Abs", new RelayCommand(param => this.Abs())));
        Commands.Add(new CommandViewModel("Round", new RelayCommand(param => this.Round())));
        Commands.Add(new CommandViewModel("Floor", new RelayCommand(param => this.Floor())));
        Commands.Add(new CommandViewModel("Ceiling", new RelayCommand(param => this.Ceiling())));
        Commands.Add(new CommandViewModel("Truncate", new RelayCommand(param => this.Truncate())));
        Commands.Add(new CommandViewModel("Sign", new RelayCommand(param => this.Sign())));
        Commands.Add(new CommandViewModel("Max", new RelayCommand(param => this.Max())));
        Commands.Add(new CommandViewModel("Min", new RelayCommand(param => this.Min())));
        Commands.Add(new CommandViewModel("Sum", new RelayCommand(param => this.Sum())));
        Commands.Add(new CommandViewModel("Average", new RelayCommand(param => this.Average())));
        Commands.Add(new CommandViewModel("Factorial", new RelayCommand(param => this.Factorial())));
        Commands.Add(new CommandViewModel("Mod", new RelayCommand(param => this.Mod())));
        Commands.Add(new CommandViewModel("Rem", new RelayCommand(param => this.Rem())));
        Commands.Add(new CommandViewModel("DivRem", new RelayCommand(param => this.DivRem())));
        Commands.Add(new CommandViewModel("GCD", new RelayCommand(param => this.GCD())));
        Commands.Add(new CommandViewModel("LCM", new RelayCommand(param => this.LCM())));
        Commands.Add(new CommandViewModel("Hypot", new RelayCommand(param => this.Hypot())));
        Commands.Add(new CommandViewModel("Atan2", new RelayCommand(param => this.Atan2())));
        Commands.Add(new CommandViewModel("Log10", new RelayCommand(param => this.Log10())));
        Commands.Add(new CommandViewModel("Log2", new RelayCommand(param => this.Log2())));
        Commands.Add(new CommandViewModel("*/

    public int ButtonSizingNumber { get; set; } = 100;
    public int FontSizingNumber { get; set; } = 30;
    
}