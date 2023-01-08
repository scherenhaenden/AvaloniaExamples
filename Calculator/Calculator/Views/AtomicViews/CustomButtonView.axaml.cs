using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Markup.Xaml;
using Calculator.ViewModels.AtomicViewModels;

namespace Calculator.Views.AtomicViews;

public partial class CustomButtonView : UserControl
{
    public CustomButtonView()
    {
        InitializeComponent();
        DataContext = new CustomButtonViewModel();
    }
    
    public static readonly  DirectProperty<CustomButtonView, string> ButtonSizingHeightNumberProperty =
        AvaloniaProperty.RegisterDirect<CustomButtonView, string>(
            nameof(ButtonSizingHeightNumber),
            o => o.ButtonSizingHeightNumber,
            (o, v) => o.ButtonSizingHeightNumber = v);
      
    public string ButtonSizingHeightNumber { get; set; }
    
    public static readonly StyledProperty<string> ButtonSizingWidthNumberV2Property =
        AvaloniaProperty.Register<Carousel, string>(nameof(ButtonSizingWidthNumberV2), "0");
        
    public string ButtonSizingWidthNumberV2
    {
        get { return GetValue(ButtonSizingWidthNumberV2Property); }
        set { SetValue(ButtonSizingWidthNumberV2Property, value); }
    }
    
    //public string ButtonSizingWidthNumber { get; set; }
    public static readonly  DirectProperty<CustomButtonView, string> ButtonSizingWidthNumberProperty =
        AvaloniaProperty.RegisterDirect<CustomButtonView, string>(
            nameof(ButtonSizingWidthNumber),
            o => o.ButtonSizingWidthNumber,
            (o, v) => o.ButtonSizingWidthNumber = v);     
      
       
    private string _buttonSizingWidthNumber;
    public string ButtonSizingWidthNumber
    {
        get  {
                
            //GetValue(ButtonSizingWidthNumberProperty);
            
            return _buttonSizingWidthNumber;
        }
                
                
        set
        {
            if(_buttonSizingWidthNumber != value)
            {
                // get view model from datacontext
                var vm = (CustomButtonViewModel)DataContext;
                vm.ButtonSizingHeightNumber = value;
                
                this.DataContext = vm;
                
                _buttonSizingWidthNumber = value;
                ButtonSizingWidthNumberProperty.Setter(this, value);
                    
                SetAndRaise(ButtonSizingWidthNumberProperty, ref _buttonSizingWidthNumber, value);

                //ButtonSizingWidthNumberProperty.Setter(_buttonSizingWidthNumber)
                        
                ButtonSizingWidthNumberProperty.Changed.Subscribe((e) => {
                    _buttonSizingWidthNumber = e.NewValue.ToString();
                });
                    
                    
                //SetValue(ButtonSizingWidthNumberProperty, value);
                    
            }
        }
    }
    

    //public object GenericCommand { get; set; }
    public static readonly  DirectProperty<CustomButtonView, object> GenericCommandProperty =
        AvaloniaProperty.RegisterDirect<CustomButtonView, object>(
            nameof(GenericCommand),
            o => o.GenericCommand,
            (o, v) => o.GenericCommand = v,
            defaultBindingMode: BindingMode.TwoWay);
    
    public object GenericCommand {
        get => GetValue(GenericCommandProperty);
        set => SetValue(GenericCommandProperty, value);
    }
    
    //public string FontSizingNumber { get; set; }
    public static readonly  DirectProperty<CustomButtonView, string> FontSizingNumberProperty =
        AvaloniaProperty.RegisterDirect<CustomButtonView, string>(
            nameof(FontSizingNumber),
            o => o.FontSizingNumber,
            (o, v) => o.FontSizingNumber = v);
    
    public string FontSizingNumber { get; set; }
    
    //public string ButtonSizingHeightNumber { get; set; }
    

    
        
        

        
        
        
        
        
        
        //public string CommandParameter { get; set; }
        public static readonly  DirectProperty<CustomButtonView, string> CommandParameterProperty =
            AvaloniaProperty.RegisterDirect<CustomButtonView, string>(
                nameof(CommandParameter),
                o => o.CommandParameter,
                (o, v) => o.CommandParameter = v);
        
        private string _commandParameter;
        
        public string CommandParameter
        {
            get => _commandParameter;
            set
            {
                if(_commandParameter != value)
                {
                    _commandParameter = value;
                    SetAndRaise(CommandParameterProperty, ref _commandParameter, value);
                }
            }
        }
        
        //public object? Content { get; set; }
        public new static readonly DirectProperty<CustomButtonView, object> ContentProperty =
                AvaloniaProperty.RegisterDirect<CustomButtonView, object>(
                        nameof(Content),
                    o => o.Content,
                    (o, v) => o.Content = v,
                    defaultBindingMode: BindingMode.TwoWay);

        private object? _content;
        public new object? Content
        {
            get { return _content; }
            set
            {
                if (_content == value)
                {
                    return;
                }
                
                SetAndRaise(ContentProperty, ref _content, value);
                var vm = (CustomButtonViewModel)DataContext;
                vm.Content = value;
                this.DataContext = vm;
            }
        }


        /*public static readonly DependencyProperty MyPropertyProperty =
        DependencyProperty.Register(
            "MyProperty",
            typeof(object),
            typeof(MyControl),
            new PropertyMetadata(null));* /

    public object MyProperty
    {
        get => GetValue(MyPropertyProperty);
        set => SetValue(MyPropertyProperty, value);
    }*/
    
    // click event
    /*public static readonly DirectProperty<EventHandler<CustomButton>> ClickEvent =
        AvaloniaProperty.RegisterDirectEvent<CustomButtonView, EventHandler<CustomButton>>(
            nameof(Click),
            o => o.Click,
            (o, v) => o.Click += v,
            (o, v) => o.Click -= v);*/
    
    


   
    
    //public string CommandParameter { get; set; 
    

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }


}