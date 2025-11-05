using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lab03;

public partial class Bai8 : Form
{
    private int _index = 1;
    
    public Bai8()
    {
        InitializeComponent();

        ModifyBtn.Click += ModifyOnClick;
        DeleteBtn.Click += RemoveOnClick;
        ExitBtn.Click += ExitClick;

        AccountList.SelectedIndexChanged += OnSelect;
    }
    
    private void ModifyOnClick(object? sender, EventArgs e)
    {
        if (!CheckFields()) return;
        
        var rows = AccountList.Items;
        for (var i = 0; i < rows.Count; i++)
        {
            var item = rows[i];
            if (item.SubItems[1].Text != AccountNumber.Text) continue;
            
            item.SubItems[1].Text = AccountNumber.Text;
            item.SubItems[2].Text = CustomerName.Text;
            item.SubItems[3].Text = Address.Text;
            item.SubItems[4].Text = Balance.Text;
            
            MessageBox.Show(
                @"Cập nhật dữ liệu thành công!",
                @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            UpdateTotal();
            ClearFields();
            return;
        }
        
        var newItem = new ListViewItem(_index.ToString());
        newItem.SubItems.Add(AccountNumber.Text.Trim());
        newItem.SubItems.Add(CustomerName.Text.Trim());
        newItem.SubItems.Add(Address.Text.Trim());
        newItem.SubItems.Add(Balance.Text.Trim().Replace(",", "."));

        AccountList.Items.Add(newItem);
        _index++;
        
        MessageBox.Show(
            @"Thêm mới dữ liệu thành công!", 
            @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        UpdateTotal();
        ClearFields();
    }
    
    private void RemoveOnClick(object? sender, EventArgs e)
    {
        var selection = MessageBox.Show(
            @"Xóa tài khoản này?", 
            @"Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        
        if (selection == DialogResult.No) return;
        
        var rows = AccountList.Items;
        for (var i = 0; i < rows.Count; i++)
        {
            var item = rows[i];
            if (item.SubItems[1].Text != AccountNumber.Text) continue;
            
            AccountList.Items.Remove(item);
            for (var j = i; j < rows.Count; j++)
                rows[j].SubItems[0].Text = (j + 1).ToString();
            
            MessageBox.Show(
                @"Xóa tài khoản thành công", 
                @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            UpdateTotal();
            ClearFields(); 
            _index--;
            
            return;
        }
        
        MessageBox.Show(
            @"Không tìm thấy số tài khoản cần xóa", 
            @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void OnSelect(object? sender, EventArgs e)
    {
        if (AccountList.SelectedItems.Count <= 0) return;
        
        var item = AccountList.SelectedItems[0];
        
        AccountNumber.Text = item.SubItems[1].Text;
        CustomerName.Text = item.SubItems[2].Text;
        Address.Text = item.SubItems[3].Text;
        Balance.Text = item.SubItems[4].Text;
    }

    private static void ExitClick(object? sender, EventArgs e)
    {
        Application.Exit();
    }

    private bool CheckFields()
    {
        var validAccountNumber = int.TryParse(AccountNumber.Text.Trim(), out _);
        var validBalance = float.TryParse(Balance.Text.Trim(), out _);
        
        if (
            validAccountNumber && 
            (CustomerName.Text.Trim() != "") &&
            (Address.Text.Trim() != "") && 
            validBalance
            ) return true;
        
        if (!validAccountNumber) 
            MessageBox.Show(
                @"Số tài khoản không hợp lệ!",
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else if (!validBalance)
            MessageBox.Show(
                @"Số dư không hợp lệ!",
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        else
            MessageBox.Show(
                @"Vui lòng nhập đầy đủ thông tin!",
                @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        return false;
    }

    private void ClearFields()
    {
        AccountNumber.Text = "";
        CustomerName.Text = "";
        Address.Text = "";
        Balance.Text = "";
    }

    private void UpdateTotal()
    {
        var total = 0.0f;
        var rows = AccountList.Items;
        for (var i = 0; i < rows.Count; i++)
            total += float.Parse(rows[i].SubItems[4].Text);
        
        Total.Text = total.ToString(CultureInfo.CurrentCulture) + @"đ";
    }
}