using System;
using System.Windows.Forms;

namespace Lab03;

public partial class Bai6 : Form
{
    public Bai6()
    {
        InitializeComponent();
        Btn0.Click += TypeInput;
        Btn1.Click += TypeInput;
        Btn2.Click += TypeInput;
        Btn3.Click += TypeInput;
        Btn4.Click += TypeInput;
        Btn5.Click += TypeInput;
        Btn6.Click += TypeInput;
        Btn7.Click += TypeInput;
        Btn8.Click += TypeInput;
        Btn9.Click += TypeInput;
        SwitchBtn.Click += TypeInput;
        BtnDot.Click += TypeInput; 
        BtnAdd.Click += TypeInput;
        BtnSub.Click += TypeInput;
        BtnMul.Click += TypeInput;
        BtnDiv.Click += TypeInput;
        BtnMod.Click += TypeInput;
        BtnSqrt.Click += TypeInput;
        BtnFrac.Click += TypeInput;
        CalcBtn.Click += Calc;
        BackspaceBtn.Click += Backspace;
        CEBtn.Click += ClearEntry;
        CBtn.Click += ClearAll;
        MCBtn.Click += MemClear;
        MRBtn.Click += MemRecall;
        MSBtn.Click += MemStore;
        MPlusBtn.Click += MemAdd;
    }

    private void TypeInput(object? sender, EventArgs e)
    {
        if (sender is not Button button) return;

        var name = button.Name[3..];
        switch (name)
        {
            case "Sqrt":
                break;
            case "Frac":
                break;
            default:
                break;
        }
    }

    private void Calc(object? sender, EventArgs e)
    {
        
    }

    private void Backspace(object? sender, EventArgs e)
    {
        
    }

    private void ClearEntry(object? sender, EventArgs e)
    {
        
    }

    private void ClearAll(object? sender, EventArgs e)
    {
        
    }

    private void MemClear(object? sender, EventArgs e)
    {
        
    }

    private void MemRecall(object? sender, EventArgs e)
    {
        
    }

    private void MemStore(object? sender, EventArgs e)
    {
        
    }
    
    private void MemAdd(object? sender, EventArgs e)
    {
        
    }
}