namespace HouseHold
{
  partial class Form_Menu
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
      this.SuspendLayout();
      // 
      // button_AddBankData
      // 
      this.button_AddBankData.Location = new System.Drawing.Point(62, 66);
      this.button_AddBankData.Name = "button_AddBankData";
      this.button_AddBankData.Size = new System.Drawing.Size(150, 23);
      this.button_AddBankData.TabIndex = 0;
      this.button_AddBankData.Text = "Add Bank Data";
      this.button_AddBankData.UseVisualStyleBackColor = true;
      this.button_AddBankData.Click += new System.EventHandler(this.button_AddBankData_Click);
      // 
      // button_SetupSheet
      // 
      this.button_SetupSheet.Location = new System.Drawing.Point(62, 25);
      this.button_SetupSheet.Name = "button_SetupSheet";
      this.button_SetupSheet.Size = new System.Drawing.Size(150, 23);
      this.button_SetupSheet.TabIndex = 1;
      this.button_SetupSheet.Text = "Setup Sheet";
      this.button_SetupSheet.UseVisualStyleBackColor = true;
      this.button_SetupSheet.Click += new System.EventHandler(this.button_SetupSheet_Click);
      // 
      // Form_Menu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(273, 228);
      this.Controls.Add(this.button_SetupSheet);
      this.Controls.Add(this.button_AddBankData);
      this.Name = "Form_Menu";
      this.Text = "HouseHold menu";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button_AddBankData;
    private System.Windows.Forms.Button button_SetupSheet;
  }
}