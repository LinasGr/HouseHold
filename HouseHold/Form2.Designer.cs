namespace HouseHold
{
  partial class Form2
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
      this.label_Name = new System.Windows.Forms.Label();
      this.textBox_Name = new System.Windows.Forms.TextBox();
      this.textBox_SheetID = new System.Windows.Forms.TextBox();
      this.label_SheetID = new System.Windows.Forms.Label();
      this.button_OK = new System.Windows.Forms.Button();
      this.button_Cancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label_Name
      // 
      this.label_Name.AutoSize = true;
      this.label_Name.Location = new System.Drawing.Point(59, 45);
      this.label_Name.Name = "label_Name";
      this.label_Name.Size = new System.Drawing.Size(35, 13);
      this.label_Name.TabIndex = 0;
      this.label_Name.Text = "Name";
      // 
      // textBox_Name
      // 
      this.textBox_Name.Location = new System.Drawing.Point(100, 38);
      this.textBox_Name.Name = "textBox_Name";
      this.textBox_Name.Size = new System.Drawing.Size(140, 20);
      this.textBox_Name.TabIndex = 1;
      // 
      // textBox_SheetID
      // 
      this.textBox_SheetID.Location = new System.Drawing.Point(100, 12);
      this.textBox_SheetID.Name = "textBox_SheetID";
      this.textBox_SheetID.Size = new System.Drawing.Size(492, 20);
      this.textBox_SheetID.TabIndex = 3;
      // 
      // label_SheetID
      // 
      this.label_SheetID.AutoSize = true;
      this.label_SheetID.Location = new System.Drawing.Point(14, 19);
      this.label_SheetID.Name = "label_SheetID";
      this.label_SheetID.Size = new System.Drawing.Size(80, 13);
      this.label_SheetID.TabIndex = 2;
      this.label_SheetID.Text = "SpreadSheetID";
      this.label_SheetID.Click += new System.EventHandler(this.label_SheetID_Click);
      // 
      // button_OK
      // 
      this.button_OK.Location = new System.Drawing.Point(152, 226);
      this.button_OK.Name = "button_OK";
      this.button_OK.Size = new System.Drawing.Size(75, 23);
      this.button_OK.TabIndex = 4;
      this.button_OK.Text = "OK";
      this.button_OK.UseVisualStyleBackColor = true;
      this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
      // 
      // button_Cancel
      // 
      this.button_Cancel.Location = new System.Drawing.Point(233, 226);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(75, 23);
      this.button_Cancel.TabIndex = 5;
      this.button_Cancel.Text = "Cancel";
      this.button_Cancel.UseVisualStyleBackColor = true;
      this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(624, 270);
      this.Controls.Add(this.button_Cancel);
      this.Controls.Add(this.button_OK);
      this.Controls.Add(this.textBox_SheetID);
      this.Controls.Add(this.label_SheetID);
      this.Controls.Add(this.textBox_Name);
      this.Controls.Add(this.label_Name);
      this.Name = "Form2";
      this.Text = "Setup";
      this.Activated += new System.EventHandler(this.Form2_Activated);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_Name;
    private System.Windows.Forms.TextBox textBox_Name;
    private System.Windows.Forms.TextBox textBox_SheetID;
    private System.Windows.Forms.Label label_SheetID;
    private System.Windows.Forms.Button button_OK;
    private System.Windows.Forms.Button button_Cancel;
  }
}