using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lab03;

public partial class Bai7 : Form
{
    private List<Button> chosenSlots = [];
    private int total = 0;
    
    public Bai7()
    {
        InitializeComponent();
        
        Slot1A.Click += OnSlotChoose;
        Slot2A.Click += OnSlotChoose;
        Slot3A.Click += OnSlotChoose;
        Slot4A.Click += OnSlotChoose;
        Slot5A.Click += OnSlotChoose;
        Slot6B.Click += OnSlotChoose;
        Slot7B.Click += OnSlotChoose;
        Slot8B.Click += OnSlotChoose;
        Slot9B.Click += OnSlotChoose;
        Slot10B.Click += OnSlotChoose;
        Slot11C.Click += OnSlotChoose;
        Slot12C.Click += OnSlotChoose;
        Slot13C.Click += OnSlotChoose;
        Slot14C.Click += OnSlotChoose;
        Slot15C.Click += OnSlotChoose;

        ChooseBtn.Click += OnChoose;
        CancelBtn.Click += OnCancel;
        ExitBtn.Click += Exit;
    }

    private void OnChoose(object? sender, EventArgs e)
    {
        if (chosenSlots.Count == 0) return;
        
        foreach (var slot in chosenSlots)
            slot.BackColor = Color.Yellow;
        chosenSlots.Clear();
        
        Total.Text = total.ToString();
        total = 0;
    }

    private void OnCancel(object? sender, EventArgs e)
    {
        if (chosenSlots.Count == 0) return;
        
        foreach (var slot in chosenSlots)
            slot.BackColor = Color.White;
        chosenSlots.Clear();
        
        total = 0;
        Total.Text = total.ToString();
    }

    private static void Exit(object? sender, EventArgs e)
    {
        Application.Exit();
    }

    private void OnSlotChoose(object? sender, EventArgs e)
    {
        if (sender is not Button button) return;

        if (button.BackColor == Color.White)
        {
            button.BackColor = Color.Blue;
            chosenSlots.Add(button);
            total += GetPrice(button);
            return;
        }

        if (button.BackColor == Color.Blue)
        {
            button.BackColor = Color.White;
            chosenSlots.Remove(button);
            total -= GetPrice(button);
            return;
        }

        MessageBox.Show(
            @"Vị trí này đã được bán",
            @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning
        );
    }

    private static int GetPrice(Button button)
    {
        return button.Name[^1] switch
        {
            'A' => 5000,
            'B' => 6500,
            _ => 8000
        };
    }
}