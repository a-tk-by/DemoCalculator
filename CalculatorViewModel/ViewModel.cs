using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalculatorViewModel;

//TODO: bind everything
public sealed class ViewModel : INotifyPropertyChanged
{
    private readonly Calculator.Calculator calculator = new();

    public ICommand CalculateCommand { get; } = null!; //TODO: connect command with 'Calculate' method


    private void Calculate()
    {
        if (this.operationName is null)
        {
            return;
        }

        try
        {
            Result = this.calculator.Calculate(this.operationName, Arguments);
            ErrorMessage = null;
        }
        catch (Calculator.CalculatorException ex)
        {
            ErrorMessage = ex.Message;
        }
    }

    private string? operationName;

    public string? OperationName
    {
        get => this.operationName;
        set
        {
            this.operationName = value;
            this.RaisePropertyChanged();
        }
    }

    public double[] Arguments { get; set; } = Array.Empty<double>();


    private double result;

    public double Result
    {
        get => this.result;
        private set
        {
            this.result = value;
            this.RaisePropertyChanged();
        }
    }

    private string? errorMessage;

    public string? ErrorMessage
    {
        get => this.errorMessage;
        set
        {
            this.errorMessage = value;
            this.RaisePropertyChanged();
        }
    }

    private void RaisePropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}