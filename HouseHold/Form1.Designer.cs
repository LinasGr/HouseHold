namespace HouseHold
{
  partial class Form_AddUserData
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
      this.label_User = new System.Windows.Forms.Label();
      this.label_Explanation = new System.Windows.Forms.Label();
      this.label_IBAN = new System.Windows.Forms.Label();
      this.textBox_Explanation = new System.Windows.Forms.TextBox();
      this.textBox_IBAN = new System.Windows.Forms.TextBox();
      this.button_Save = new System.Windows.Forms.Button();
      this.button_Cancel = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label_User
      // 
      this.label_User.AutoSize = true;
      this.label_User.Location = new System.Drawing.Point(238, 15);
      this.label_User.Name = "label_User";
      this.label_User.Size = new System.Drawing.Size(57, 13);
      this.label_User.TabIndex = 0;
      this.label_User.Text = "UserName";
      // 
      // label_Explanation
      // 
      this.label_Explanation.AutoSize = true;
      this.label_Explanation.Location = new System.Drawing.Point(12, 54);
      this.label_Explanation.Name = "label_Explanation";
      this.label_Explanation.Size = new System.Drawing.Size(62, 13);
      this.label_Explanation.TabIndex = 1;
      this.label_Explanation.Text = "Explanation";
      // 
      // label_IBAN
      // 
      this.label_IBAN.AutoSize = true;
      this.label_IBAN.Location = new System.Drawing.Point(42, 85);
      this.label_IBAN.Name = "label_IBAN";
      this.label_IBAN.Size = new System.Drawing.Size(32, 13);
      this.label_IBAN.TabIndex = 2;
      this.label_IBAN.Text = "IBAN";
      // 
      // textBox_Explanation
      // 
      this.textBox_Explanation.Location = new System.Drawing.Point(80, 51);
      this.textBox_Explanation.Name = "textBox_Explanation";
      this.textBox_Explanation.Size = new System.Drawing.Size(415, 20);
      this.textBox_Explanation.TabIndex = 3;
      // 
      // textBox_IBAN
      // 
      this.textBox_IBAN.Location = new System.Drawing.Point(80, 82);
      this.textBox_IBAN.Name = "textBox_IBAN";
      this.textBox_IBAN.Size = new System.Drawing.Size(415, 20);
      this.textBox_IBAN.TabIndex = 4;
      // 
      // button_Save
      // 
      this.button_Save.Location = new System.Drawing.Point(189, 126);
      this.button_Save.Name = "button_Save";
      this.button_Save.Size = new System.Drawing.Size(75, 23);
      this.button_Save.TabIndex = 5;
      this.button_Save.Text = "Save";
      this.button_Save.UseVisualStyleBackColor = true;
      this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
      // 
      // button_Cancel
      // 
      this.button_Cancel.Location = new System.Drawing.Point(270, 126);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(75, 23);
      this.button_Cancel.TabIndex = 6;
      this.button_Cancel.Text = "Cancel";
      this.button_Cancel.UseVisualStyleBackColor = true;
      // 
      // Form_AddUserData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(535, 189);
      this.Controls.Add(this.button_Cancel);
      this.Controls.Add(this.button_Save);
      this.Controls.Add(this.textBox_IBAN);
      this.Controls.Add(this.textBox_Explanation);
      this.Controls.Add(this.label_IBAN);
      this.Controls.Add(this.label_Explanation);
      this.Controls.Add(this.label_User);
      this.Name = "Form_AddUserData";
      this.Text = "HouseHold Add user data";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_User;
    private System.Windows.Forms.Label label_Explanation;
    private System.Windows.Forms.Label label_IBAN;
    private System.Windows.Forms.TextBox textBox_Explanation;
    private System.Windows.Forms.TextBox textBox_IBAN;
    private System.Windows.Forms.Button button_Save;
    private System.Windows.Forms.Button button_Cancel;
  }
}