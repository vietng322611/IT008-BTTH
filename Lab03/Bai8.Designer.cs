using System.ComponentModel;

namespace Lab03;

partial class Bai8
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        Label1 = new System.Windows.Forms.Label();
        Label2 = new System.Windows.Forms.Label();
        Total = new System.Windows.Forms.TextBox();
        AccountNumber = new System.Windows.Forms.TextBox();
        Label3 = new System.Windows.Forms.Label();
        CustomerName = new System.Windows.Forms.TextBox();
        Label4 = new System.Windows.Forms.Label();
        Address = new System.Windows.Forms.TextBox();
        Label5 = new System.Windows.Forms.Label();
        Balance = new System.Windows.Forms.TextBox();
        Label6 = new System.Windows.Forms.Label();
        ModifyBtn = new System.Windows.Forms.Button();
        DeleteBtn = new System.Windows.Forms.Button();
        ExitBtn = new System.Windows.Forms.Button();
        AccountList = new System.Windows.Forms.ListView();
        IDCol = new System.Windows.Forms.ColumnHeader();
        AccountNumberCol = new System.Windows.Forms.ColumnHeader();
        CustomerNameCol = new System.Windows.Forms.ColumnHeader();
        AddressCol = new System.Windows.Forms.ColumnHeader();
        BalanceCol = new System.Windows.Forms.ColumnHeader();
        SuspendLayout();
        // 
        // Label1
        // 
        Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 31.800001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Label1.ForeColor = System.Drawing.Color.Blue;
        Label1.Location = new System.Drawing.Point(3, 2);
        Label1.Name = "Label1";
        Label1.Size = new System.Drawing.Size(897, 86);
        Label1.TabIndex = 0;
        Label1.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
        Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Label2
        // 
        Label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Label2.Location = new System.Drawing.Point(549, 601);
        Label2.Name = "Label2";
        Label2.Size = new System.Drawing.Size(87, 27);
        Label2.TabIndex = 2;
        Label2.Text = "Tổng tiền:";
        Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // Total
        // 
        Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Total.Location = new System.Drawing.Point(642, 601);
        Total.Name = "Total";
        Total.ReadOnly = true;
        Total.Size = new System.Drawing.Size(248, 27);
        Total.TabIndex = 3;
        Total.TabStop = false;
        // 
        // AccountNumber
        // 
        AccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        AccountNumber.Location = new System.Drawing.Point(257, 91);
        AccountNumber.Name = "AccountNumber";
        AccountNumber.Size = new System.Drawing.Size(513, 27);
        AccountNumber.TabIndex = 1;
        // 
        // Label3
        // 
        Label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Label3.Location = new System.Drawing.Point(81, 91);
        Label3.Name = "Label3";
        Label3.Size = new System.Drawing.Size(170, 27);
        Label3.TabIndex = 4;
        Label3.Text = "Số tài khoản";
        Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // CustomerName
        // 
        CustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        CustomerName.Location = new System.Drawing.Point(257, 134);
        CustomerName.Name = "CustomerName";
        CustomerName.Size = new System.Drawing.Size(513, 27);
        CustomerName.TabIndex = 2;
        // 
        // Label4
        // 
        Label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Label4.Location = new System.Drawing.Point(81, 134);
        Label4.Name = "Label4";
        Label4.Size = new System.Drawing.Size(170, 27);
        Label4.TabIndex = 6;
        Label4.Text = "Tên khách hàng";
        Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Address
        // 
        Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Address.Location = new System.Drawing.Point(257, 177);
        Address.Name = "Address";
        Address.Size = new System.Drawing.Size(513, 27);
        Address.TabIndex = 3;
        // 
        // Label5
        // 
        Label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Label5.Location = new System.Drawing.Point(81, 177);
        Label5.Name = "Label5";
        Label5.Size = new System.Drawing.Size(170, 27);
        Label5.TabIndex = 10;
        Label5.Text = "Địa chỉ khách hàng";
        Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // Balance
        // 
        Balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        Balance.Location = new System.Drawing.Point(257, 221);
        Balance.Name = "Balance";
        Balance.Size = new System.Drawing.Size(513, 27);
        Balance.TabIndex = 4;
        // 
        // Label6
        // 
        Label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        Label6.Location = new System.Drawing.Point(81, 221);
        Label6.Name = "Label6";
        Label6.Size = new System.Drawing.Size(170, 27);
        Label6.TabIndex = 14;
        Label6.Text = "Số tiền trong tài khoản";
        Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // ModifyBtn
        // 
        ModifyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        ModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        ModifyBtn.Location = new System.Drawing.Point(408, 264);
        ModifyBtn.Name = "ModifyBtn";
        ModifyBtn.Size = new System.Drawing.Size(152, 29);
        ModifyBtn.TabIndex = 5;
        ModifyBtn.Text = "Thêm / Cập nhật";
        ModifyBtn.UseVisualStyleBackColor = true;
        // 
        // DeleteBtn
        // 
        DeleteBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        DeleteBtn.Location = new System.Drawing.Point(577, 264);
        DeleteBtn.Name = "DeleteBtn";
        DeleteBtn.Size = new System.Drawing.Size(85, 29);
        DeleteBtn.TabIndex = 6;
        DeleteBtn.Text = "Xóa";
        DeleteBtn.UseVisualStyleBackColor = false;
        // 
        // ExitBtn
        // 
        ExitBtn.BackColor = System.Drawing.SystemColors.ControlLight;
        ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        ExitBtn.Location = new System.Drawing.Point(685, 264);
        ExitBtn.Name = "ExitBtn";
        ExitBtn.Size = new System.Drawing.Size(85, 29);
        ExitBtn.TabIndex = 7;
        ExitBtn.Text = "Thoát";
        ExitBtn.UseVisualStyleBackColor = false;
        // 
        // AccountList
        // 
        AccountList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        AccountList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { IDCol, AccountNumberCol, CustomerNameCol, AddressCol, BalanceCol });
        AccountList.Location = new System.Drawing.Point(12, 299);
        AccountList.MultiSelect = false;
        AccountList.Name = "AccountList";
        AccountList.Size = new System.Drawing.Size(878, 296);
        AccountList.TabIndex = 15;
        AccountList.TabStop = false;
        AccountList.UseCompatibleStateImageBehavior = false;
        AccountList.View = System.Windows.Forms.View.Details;
        // 
        // IDCol
        // 
        IDCol.Name = "IDCol";
        IDCol.Text = "STT";
        IDCol.Width = 50;
        // 
        // AccountNumberCol
        // 
        AccountNumberCol.Name = "AccountNumberCol";
        AccountNumberCol.Text = "Mã tài khoản";
        AccountNumberCol.Width = 160;
        // 
        // CustomerNameCol
        // 
        CustomerNameCol.Name = "CustomerNameCol";
        CustomerNameCol.Text = "Tên khách hàng";
        CustomerNameCol.Width = 250;
        // 
        // AddressCol
        // 
        AddressCol.Name = "AddressCol";
        AddressCol.Text = "Địa chỉ";
        AddressCol.Width = 250;
        // 
        // BalanceCol
        // 
        BalanceCol.Name = "BalanceCol";
        BalanceCol.Text = "Số tiền";
        BalanceCol.Width = 165;
        // 
        // Bai8
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.SystemColors.Control;
        ClientSize = new System.Drawing.Size(902, 645);
        Controls.Add(AccountList);
        Controls.Add(ExitBtn);
        Controls.Add(DeleteBtn);
        Controls.Add(ModifyBtn);
        Controls.Add(Balance);
        Controls.Add(Address);
        Controls.Add(CustomerName);
        Controls.Add(AccountNumber);
        Controls.Add(Label4);
        Controls.Add(Label5);
        Controls.Add(Label6);
        Controls.Add(Label3);
        Controls.Add(Total);
        Controls.Add(Label2);
        Controls.Add(Label1);
        Location = new System.Drawing.Point(19, 19);
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ColumnHeader AccountNumberCol;

    private System.Windows.Forms.ColumnHeader AddressCol;
    private System.Windows.Forms.ColumnHeader CustomerNameCol;

    private System.Windows.Forms.ColumnHeader BalanceCol;

    private System.Windows.Forms.ColumnHeader IDCol;

    private System.Windows.Forms.ListView AccountList;

    private System.Windows.Forms.Label Label1;
    
    private System.Windows.Forms.Button ModifyBtn;
    private System.Windows.Forms.Button DeleteBtn;
    private System.Windows.Forms.Button ExitBtn;
    
    private System.Windows.Forms.TextBox CustomerName;
    private System.Windows.Forms.TextBox AccountNumber;
    private System.Windows.Forms.TextBox Address;
    private System.Windows.Forms.TextBox Balance;
    
    private System.Windows.Forms.Label Label3;
    private System.Windows.Forms.Label Label4;
    private System.Windows.Forms.Label Label5;
    private System.Windows.Forms.Label Label6;
    
    private System.Windows.Forms.Label Label2;
    private System.Windows.Forms.TextBox Total;

    #endregion
}