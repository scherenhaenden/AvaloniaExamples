using System;
using System.Reactive;
using Microsoft.VisualBasic;
using ReactiveUI;

namespace Calculator.ViewModels.SubViewModels;

public class BasicCalculatorViewModel: ViewModelBase
{
    private float _accumulativeNumber = 0;
    private float _secondNumber = 0;
    private float _lastNumberIntroduced = 0;
    private string _lastOperator = "";
    private bool _setNewNumber = false;
    
    
    public int ButtonSizingNumber { get; set; } = 200;
    public int FontSizingNumber { get; set; } = 100;
    
    
    
    private string result = "0";
    public string Result 
    {
        get => result;
        set => this.RaiseAndSetIfChanged(ref result, value);
    }

    public BasicCalculatorViewModel()
    {
        AddDigitCommand = ReactiveCommand.Create<string>(number =>

            {
                if(_setNewNumber)
                {
                    Result = number;
                    _setNewNumber = false;
                }
                else
                {
                    if(Result == "0")
                    {
                        Result = number;
                    }
                    else
                    {
                        Result += number;
                    }
                }
                _lastNumberIntroduced = float.Parse(Result);
               
                
                /*if (_lastOperator != "")
                {
                    Result = "0";
                }*/
                
                /*if(Result == "0")
                {
                    Result = number;
                    //_accumulativeNumber = float.Parse(Result);
                }
                else
                {
                    Result += number;
                    //_accumulativeNumber = float.Parse(Result);
                }*/
                _setNewNumber = false;
                
                
               
                
   
            });
        
        AddOperatorCommand = ReactiveCommand.Create<string>(operatorString =>
            {
                _lastOperator = operatorString;
                if(_accumulativeNumber == 0)
                {
                    _accumulativeNumber = _lastNumberIntroduced;
                }
                else
                {
                    if (operatorString == "=")
                    {
                        operatorString = _lastOperator;
                    }
                    _accumulativeNumber = Calculate(_accumulativeNumber, _lastNumberIntroduced, operatorString);
                    Result = _accumulativeNumber.ToString();
                   // _secondNumber = _accumulativeNumber;
                }
                _setNewNumber = true;
             
            });
        
            CalculateResultCommand = ReactiveCommand.Create(() =>
            {
                _secondNumber = float.Parse(Result);
                _accumulativeNumber = Calculate(_accumulativeNumber, _secondNumber, _lastOperator);
                _secondNumber = 0;
                _lastOperator = "";
                Result = _accumulativeNumber.ToString();
                _accumulativeNumber = 0;
            });

    }
    
    // Calculate
    private float Calculate(float firstNumber, float secondNumber, string operatorString)
    {
        switch (operatorString)
        {
            case "+":
                return firstNumber + secondNumber;
            case "-":
                return firstNumber - secondNumber;
            case "*":
                return firstNumber * secondNumber;
            case "/":
                return firstNumber / secondNumber;
            default:
                return 0;
        }
    }
    
    public void Add(int number)
    {
        Result += number;
    }
    
    // add AddDigitCommand
    public ReactiveCommand<string, Unit> AddDigitCommand { get; } 
    public void RunAddDigit(int number)
    {
        Result += number;
    }
    // AddOperatorCommand
    public ReactiveCommand<string, Unit> AddOperatorCommand { get; }
    public void RunAddOperator(string operatorString)
    {
        Result += operatorString;
    }
    
    // CalculateResultCommand
    public ReactiveCommand<Unit, Unit> CalculateResultCommand { get; }
    public object ClearCommand { get; }
}