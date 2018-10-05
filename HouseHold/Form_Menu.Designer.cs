namespace HouseHold
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
      this.button_BrowsYourData = new System.Windows.Forms.Button();
      this.button_AddServiceData = new System.Windows.Forms.Button();
      this.button_Close = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // button_AddBankData
      // 
      this.button_AddBankData.BackColor = System.Drawing.Color.Yellow;
      this.button_AddBankData.Location = new System.Drawing.Point(62, 54);
      this.button_AddBankData.Name = "button_AddBankData";
      this.button_AddBankData.Size = new System.Drawing.Size(150, 23);
      this.button_AddBankData.TabIndex = 0;
      this.button_AddBankData.Text = "Add Bank Data";
      this.button_AddBankData.UseVisualStyleBackColor = false;
      this.button_AddBankData.Click += new System.EventHandler(this.Button_AddBankData_Click);
      // 
      // button_SetupSheet
      // 
      this.button_SetupSheet.BackColor = System.Drawing.Color.Red;
      this.button_SetupSheet.Location = new System.Drawing.Point(62, 25);
      this.button_SetupSheet.Name = "button_SetupSheet";
      this.button_SetupSheet.Size = new System.Drawing.Size(150, 23);
      this.button_SetupSheet.TabIndex = 1;
      this.button_SetupSheet.Text = "Setup Sheet";
      this.button_SetupSheet.UseVisualStyleBackColor = false;
      this.button_SetupSheet.Click += new System.EventHandler(this.Button_SetupSheet_Click);
      // 
      // button_AddUserData
      // 
      this.button_AddUserData.BackColor = System.Drawing.Color.Yellow;
      this.button_AddUserData.Location = new System.Drawing.Point(62, 83);
      this.button_AddUserData.Name = "button_AddUserData";
      this.button_AddUserData.Size = new System.Drawing.Size(150, 23);
      this.button_AddUserData.TabIndex = 2;
      this.button_AddUserData.Text = "Add User IBAN";
      this.button_AddUserData.UseVisualStyleBackColor = false;
      this.button_AddUserData.Click += new System.EventHandler(this.Button_AddUserIBAN_Click);
      // 
      // button_BrowsYourData
      // 
      this.button_BrowsYourData.BackColor = System.Drawing.Color.Lime;
      this.button_BrowsYourData.Location = new System.Drawing.Point(62, 141);
      this.button_BrowsYourData.Name = "button_BrowsYourData";
      this.button_BrowsYourData.Size = new System.Drawing.Size(150, 23);
      this.button_BrowsYourData.TabIndex = 3;
      this.button_BrowsYourData.Text = "Browse Your data";
      this.button_BrowsYourData.UseVisualStyleBackColor = false;
      this.button_BrowsYourData.Click += new System.EventHandler(this.Button_BrowseYourData_Click);
      // 
      // button_AddServiceData
      // 
      this.button_AddServiceData.BackColor = System.Drawing.Color.Lime;
      this.button_AddServiceData.Location = new System.Drawing.Point(62, 112);
      this.button_AddServiceData.Name = "button_AddServiceData";
      this.button_AddServiceData.Size = new System.Drawing.Size(150, 23);
      this.button_AddServiceData.TabIndex = 4;
      this.button_AddServiceData.Text = "Add Service Data";
      this.button_AddServiceData.UseVisualStyleBackColor = false;
      this.button_AddServiceData.Click += new System.EventHandler(this.button_AddServiceData_Click);
      // 
      // button_Close
      // 
      this.button_Close.BackColor = System.Drawing.Color.Lime;
      this.button_Close.Location = new System.Drawing.Point(62, 170);
      this.button_Close.Name = "button_Close";
      this.button_Close.Size = new System.Drawing.Size(150, 23);
      this.button_Close.TabIndex = 5;
      this.button_Close.Text = "Close";
      this.button_Close.UseVisualStyleBackColor = false;
      this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
      // 
      // FormMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(276, 215);
      this.Controls.Add(this.button_Close);
      this.Controls.Add(this.button_AddServiceData);
      this.Controls.Add(this.button_BrowsYourData);
      this.Controls.Add(this.button_AddUserData);
      this.Controls.Add(this.button_SetupSheet);
      this.Controls.Add(this.button_AddBankData);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "HouseHold menu";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button_AddBankData;
    private System.Windows.Forms.Button button_SetupSheet;
    private System.Windows.Forms.Button button_AddUserData;
    private System.Windows.Forms.Button button_BrowsYourData;
    private System.Windows.Forms.Button button_AddServiceData;
    private System.Windows.Forms.Button button_Close;
  }
}