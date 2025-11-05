using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lab03;

public partial class Bai6 : Form
{
    private double _firstNumber;
    private bool _isNewEntry = true;
    private double _memory;
    
    public Bai6()
    {
        InitializeComponent();
        Btn0.Click += OnNumberClick;
        Btn1.Click += OnNumberClick;
        Btn2.Click += OnNumberClick;
        Btn3.Click += OnNumberClick;
        Btn4.Click += OnNumberClick;
        Btn5.Click += OnNumberClick;
        Btn6.Click += OnNumberClick;
        Btn7.Click += OnNumberClick;
        Btn8.Click += OnNumberClick;
        Btn9.Click += OnNumberClick;
        BtnDot.Click += OnNumberClick;
        BtnAdd.Click += OnOperatorClick;
        BtnSub.Click += OnOperatorClick;
        BtnMul.Click += OnOperatorClick;
        BtnDiv.Click += OnOperatorClick;
        BtnMod.Click += OnOperatorClick;
        SwitchOpBtn.Click += OnSwitchOpClick;
        BtnSqrt.Click += OnSqrtClick;
        BtnFrac.Click += OnFractionClick;
        CalcBtn.Click += Calc;
        BackspaceBtn.Click += Backspace;
        CEBtn.Click += ClearEntry;
        CBtn.Click += ClearAll;
        MCBtn.Click += (_, _) => _memory = 0;
        MRBtn.Click += (_, _) =>
            NumberDisplay.Text = _memory.ToString(CultureInfo.CurrentCulture);
        MSBtn.Click += (_, _) =>
            _memory = double.TryParse(NumberDisplay.Text, out var val) ? val : 0;
        MPlusBtn.Click += (_, _) =>
            _memory += double.TryParse(NumberDisplay.Text, out var val) ? val : 0;
    }

    private double? DoMath(double secondNumber)
    {
        double result;
        switch (OperationDisplay.Text)
        {
            case "+": result = _firstNumber + secondNumber; break;
            case "-": result = _firstNumber - secondNumber; break;
            case "*": result = _firstNumber * secondNumber; break;
            case "/":
                if (secondNumber == 0) return null;
                result = _firstNumber / secondNumber;
                break;
            case "%": result = _firstNumber % secondNumber; break;
            default: result = secondNumber; break;
        }

        return result;
    }

    private void OnNumberClick(object? sender, EventArgs e)
    {
        if (sender is not Button button) return;
        
        if (_isNewEntry)
        {
            NumberDisplay.Text = "";
            _isNewEntry = false;
        }
        
        if (button.Text == "." && NumberDisplay.Text.Contains('.'))
            return;
        
        NumberDisplay.Text += button.Name[3..];
    }

    private void OnOperatorClick(object? sender, EventArgs e)
    {
        if (sender is not Button button) return;
        if (!double.TryParse(NumberDisplay.Text, out var number)) return;

        var result = DoMath(number);
        if (result.HasValue)
            _firstNumber = result.Value;
        
        OperationDisplay.Text = button.Text;
        _isNewEntry = true;
    }
    
    private void OnSwitchOpClick(object? sender, EventArgs e)
    {
        switch (OperationDisplay.Text)
        {
            case "+":
                OperationDisplay.Text = "-";
                return;
            case "-":
                OperationDisplay.Text = "+";
                return;
        }
    }
    
    private void OnSqrtClick(object? sender, EventArgs e)
    {
        if (!double.TryParse(NumberDisplay.Text, out var val)) return;
        
        if (val < 0)
        {
            MessageBox.Show("Math Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        NumberDisplay.Text = Math.Sqrt(val).ToString(CultureInfo.CurrentCulture);
        _isNewEntry = true;
    }

    private void OnFractionClick(object? sender, EventArgs e)
    {
        if (!double.TryParse(NumberDisplay.Text, out var val)) return;
        
        if (val == 0)
        {
            MessageBox.Show("Math Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        NumberDisplay.Text = (1 / val).ToString(CultureInfo.CurrentCulture);
        _isNewEntry = true;
    }

    private void Calc(object? sender, EventArgs e)
    {
        if (!double.TryParse(NumberDisplay.Text, out var secondNumber)) return;
        
        var result = DoMath(secondNumber);
        if (result.HasValue)
        {
            NumberDisplay.Text = result.Value.ToString(CultureInfo.CurrentCulture);
            OperationDisplay.Text = "";
            _isNewEntry = true;
        }
        else
            MessageBox.Show("Math Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void Backspace(object? sender, EventArgs e)
    {
        if (!_isNewEntry && NumberDisplay.Text.Length > 0)
            NumberDisplay.Text = NumberDisplay.Text[..^1];

        if (NumberDisplay.Text == "")
            NumberDisplay.Text = "0";
    }

    private void ClearEntry(object? sender, EventArgs e)
    {
        NumberDisplay.Text = "0";
        _isNewEntry = true;
    }

    private void ClearAll(object? sender, EventArgs e)
    {
        NumberDisplay.Text = "0";
        _firstNumber = 0;
        OperationDisplay.Text = "";
        _isNewEntry = true;
    }
}