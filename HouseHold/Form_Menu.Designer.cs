﻿namespace HouseHold
{
  partial class FormMenu
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      this.button_AddBankData = new System.Windows.Forms.Button();
      this.button_SetupSheet = new System.Windows.Forms.Button();
      this.button_AddUserData = new System.Windows.Forms.Button();
      this.button_GetYourData = new System.Windows.Forms.Button();
      this.button_AddServiceData = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button_AddBankData
      // 
      this.button_AddBankData.Location = new System.Drawing.Point(62, 54);
      this.button_AddBankData.Name = "button_AddBankData";
      this.button_AddBankData.Size = new System.Drawing.Size(150, 23);
      this.button_AddBankData.TabIndex = 0;
      this.button_AddBankData.Text = "Add Bank Data";
      this.button_AddBankData.UseVisualStyleBackColor = true;
      this.button_AddBankData.Click += new System.EventHandler(this.Button_AddBankData_Click);
      // 
      // button_SetupSheet
      // 
      this.button_SetupSheet.Location = new System.Drawing.Point(62, 25);
      this.button_SetupSheet.Name = "button_SetupSheet";
      this.button_SetupSheet.Size = new System.Drawing.Size(150, 23);
      this.button_SetupSheet.TabIndex = 1;
      this.button_SetupSheet.Text = "Setup Sheet";
      this.button_SetupSheet.UseVisualStyleBackColor = true;
      this.button_SetupSheet.Click += new System.EventHandler(this.Button_SetupSheet_Click);
      // 
      // button_AddUserData
      // 
      this.button_AddUserData.Location = new System.Drawing.Point(62, 83);
      this.button_AddUserData.Name = "button_AddUserData";
      this.button_AddUserData.Size = new System.Drawing.Size(150, 23);
      this.button_AddUserData.TabIndex = 2;
      this.button_AddUserData.Text = "Add User IBAN";
      this.button_AddUserData.UseVisualStyleBackColor = true;
      this.button_AddUserData.Click += new System.EventHandler(this.Button_AddUserIBAN_Click);
      // 
      // button_GetYourData
      // 
      this.button_GetYourData.Location = new System.Drawing.Point(62, 141);
      this.button_GetYourData.Name = "button_GetYourData";
      this.button_GetYourData.Size = new System.Drawing.Size(150, 23);
      this.button_GetYourData.TabIndex = 3;
      this.button_GetYourData.Text = "Get Your Data";
      this.button_GetYourData.UseVisualStyleBackColor = true;
      this.button_GetYourData.Click += new System.EventHandler(this.Button_GetYourData_Click);
      // 
      // button_AddServiceData
      // 
      this.button_AddServiceData.Location = new System.Drawing.Point(62, 112);
      this.button_AddServiceData.Name = "button_AddServiceData";
      this.button_AddServiceData.Size = new System.Drawing.Size(150, 23);
      this.button_AddServiceData.TabIndex = 4;
      this.button_AddServiceData.Text = "Add Service Data";
      this.button_AddServiceData.UseVisualStyleBackColor = true;
      this.button_AddServiceData.Click += new System.EventHandler(this.button_AddServiceData_Click);
      // 
      // FormMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(280, 191);
      this.Controls.Add(this.button_AddServiceData);
      this.Controls.Add(this.button_GetYourData);
      this.Controls.Add(this.button_AddUserData);
      this.Controls.Add(this.button_SetupSheet);
      this.Controls.Add(this.button_AddBankData);
      this.Name = "FormMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "HouseHold menu";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button_AddBankData;
    private System.Windows.Forms.Button button_SetupSheet;
    private System.Windows.Forms.Button button_AddUserData;
    private System.Windows.Forms.Button button_GetYourData;
    private System.Windows.Forms.Button button_AddServiceData;
  }
}