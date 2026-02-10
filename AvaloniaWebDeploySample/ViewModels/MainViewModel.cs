using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AvaloniaWebDeploySample.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    public string Title => "Avalonia Controls Showcase";
    public string Subtitle => "Demonstrating Avalonia UI Controls on Web (WASM)";

    // Button demo
    [ObservableProperty]
    private int _clickCount;

    [ObservableProperty]
    private string _buttonMessage = "Click the button!";

    // TextBox demo
    [ObservableProperty]
    private string _textBoxContent = "";

    [ObservableProperty]
    private string _textBoxPreview = "Type something to see live preview...";

    // CheckBox demo
    [ObservableProperty]
    private bool _isOption1Checked;

    [ObservableProperty]
    private bool _isOption2Checked = true;

    [ObservableProperty]
    private bool? _isOption3Checked = null;

    // RadioButton demo
    [ObservableProperty]
    private bool _isRadio1Selected = true;

    [ObservableProperty]
    private bool _isRadio2Selected;

    [ObservableProperty]
    private bool _isRadio3Selected;

    // Slider demo
    [ObservableProperty]
    private double _sliderValue = 50;

    // ProgressBar demo
    [ObservableProperty]
    private double _progressValue = 65;

    // ComboBox demo
    [ObservableProperty]
    private string? _selectedItem;

    public ObservableCollection<string> ComboItems { get; } = new()
    {
        "Option 1",
        "Option 2",
        "Option 3",
        "Option 4"
    };

    // ListBox demo
    [ObservableProperty]
    private string? _selectedListItem;

    public ObservableCollection<string> ListItems { get; } = new()
    {
        "Item Alpha",
        "Item Beta",
        "Item Gamma",
        "Item Delta",
        "Item Epsilon"
    };

    // Numeric Input demo
    [ObservableProperty]
    private decimal _numericValue = 10;
    
    private const decimal MinNumericValue = 0;
    private const decimal MaxNumericValue = 100;

    // Calendar demo
    [ObservableProperty]
    private DateTimeOffset? _selectedDate = DateTimeOffset.Now;

    // ToggleSwitch demo
    [ObservableProperty]
    private bool _isToggleOn = true;

    public MainViewModel()
    {
        SelectedItem = ComboItems[0];
    }

    [RelayCommand]
    private void IncrementClick()
    {
        ClickCount++;
        ButtonMessage = $"Clicked {ClickCount} time{(ClickCount != 1 ? "s" : "")}!";
    }

    [RelayCommand]
    private void ResetClick()
    {
        ClickCount = 0;
        ButtonMessage = "Click the button!";
    }

    partial void OnTextBoxContentChanged(string value)
    {
        TextBoxPreview = string.IsNullOrEmpty(value) 
            ? "Type something to see live preview..." 
            : $"Preview: {value}";
    }

    partial void OnSliderValueChanged(double value)
    {
        ProgressValue = value;
    }

    [RelayCommand]
    private void IncrementNumeric()
    {
        if (NumericValue < MaxNumericValue)
        {
            NumericValue++;
        }
    }

    [RelayCommand]
    private void DecrementNumeric()
    {
        if (NumericValue > MinNumericValue)
        {
            NumericValue--;
        }
    }
}
