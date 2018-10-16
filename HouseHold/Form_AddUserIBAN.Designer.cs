namespace HouseHold
{
  partial class FormAddUserIban
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
      this.button_PushToSheet = new System.Windows.Forms.Button();
      this.button_Cancel = new System.Windows.Forms.Button();
      this.comboBox_IBAN = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label_ExplanationList = new System.Windows.Forms.Label();
      this.comboBox_Explanation = new System.Windows.Forms.ComboBox();
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
      this.label_Explanation.Location = new System.Drawing.Point(26, 219);
      this.label_Explanation.Name = "label_Explanation";
      this.label_Explanation.Size = new System.Drawing.Size(62, 13);
      this.label_Explanation.TabIndex = 1;
      this.label_Explanation.Text = "Explanation";
      // 
      // label_IBAN
      // 
      this.label_IBAN.AutoSize = true;
      this.label_IBAN.Location = new System.Drawing.Point(56, 110);
      this.label_IBAN.Name = "label_IBAN";
      this.label_IBAN.Size = new System.Drawing.Size(32, 13);
      this.label_IBAN.TabIndex = 2;
      this.label_IBAN.Text = "IBAN";
      // 
      // textBox_Explanation
      // 
      this.textBox_Explanation.Location = new System.Drawing.Point(94, 216);
      this.textBox_Explanation.Name = "textBox_Explanation";
      this.textBox_Explanation.Size = new System.Drawing.Size(415, 20);
      this.textBox_Explanation.TabIndex = 3;
      // 
      // textBox_IBAN
      // 
      this.textBox_IBAN.Location = new System.Drawing.Point(94, 107);
      this.textBox_IBAN.Name = "textBox_IBAN";
      this.textBox_IBAN.Size = new System.Drawing.Size(415, 20);
      this.textBox_IBAN.TabIndex = 4;
      // 
      // button_PushToSheet
      // 
      this.button_PushToSheet.BackColor = System.Drawing.Color.Yellow;
      this.button_PushToSheet.Location = new System.Drawing.Point(163, 257);
      this.button_PushToSheet.Name = "button_PushToSheet";
      this.button_PushToSheet.Size = new System.Drawing.Size(100, 23);
      this.button_PushToSheet.TabIndex = 5;
      this.button_PushToSheet.Text = "Push to sheet";
      this.button_PushToSheet.UseVisualStyleBackColor = false;
      this.button_PushToSheet.Click += new System.EventHandler(this.Button_PushToSheet_Click);
      // 
      // button_Cancel
      // 
      this.button_Cancel.BackColor = System.Drawing.Color.Lime;
      this.button_Cancel.Location = new System.Drawing.Point(269, 257);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(100, 23);
      this.button_Cancel.TabIndex = 6;
      this.button_Cancel.Text = "Close";
      this.button_Cancel.UseVisualStyleBackColor = false;
      this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
      // 
      // comboBox_IBAN
      // 
      this.comboBox_IBAN.FormattingEnabled = true;
      this.comboBox_IBAN.Location = new System.Drawing.Point(94, 71);
      this.comboBox_IBAN.Name = "comboBox_IBAN";
      this.comboBox_IBAN.Size = new System.Drawing.Size(415, 21);
      this.comboBox_IBAN.TabIndex = 7;
      this.comboBox_IBAN.SelectedIndexChanged += new System.EventHandler(this.comboBox_IBAN_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(219, 55);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(103, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "Select existing IBAN";
      // 
      // label_ExplanationList
      // 
      this.label_ExplanationList.AutoSize = true;
      this.label_ExplanationList.Location = new System.Drawing.Point(191, 163);
      this.label_ExplanationList.Name = "label_ExplanationList";
      this.label_ExplanationList.Size = new System.Drawing.Size(160, 13);
      this.label_ExplanationList.TabIndex = 10;
      this.label_ExplanationList.Text = "Select existing IBAN explanation";
      // 
      // comboBox_Explanation
      // 
      this.comboBox_Explanation.FormattingEnabled = true;
      this.comboBox_Explanation.Location = new System.Drawing.Point(94, 179);
      this.comboBox_Explanation.Name = "comboBox_Explanation";
      this.comboBox_Explanation.Size = new System.Drawing.Size(415, 21);
      this.comboBox_Explanation.TabIndex = 9;
      this.comboBox_Explanation.SelectedIndexChanged += new System.EventHandler(this.comboBox_Explanation_SelectedIndexChanged);
      // 
      // FormAddUserIban
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(535, 308);
      this.Controls.Add(this.label_ExplanationList);
      this.Controls.Add(this.comboBox_Explanation);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.comboBox_IBAN);
      this.Controls.Add(this.button_Cancel);
      this.Controls.Add(this.button_PushToSheet);
      this.Controls.Add(this.textBox_IBAN);
      this.Controls.Add(this.textBox_Explanation);
      this.Controls.Add(this.label_IBAN);
      this.Controls.Add(this.label_Explanation);
      this.Controls.Add(this.label_User);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormAddUserIban";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "HouseHold Add user IBAN";
      this.Load += new System.EventHandler(this.Form_AddUserIBAN_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_User;
    private System.Windows.Forms.Label label_Explanation;
    private System.Windows.Forms.Label label_IBAN;
    private System.Windows.Forms.TextBox textBox_Explanation;
    private System.Windows.Forms.TextBox textBox_IBAN;
    private System.Windows.Forms.Button button_PushToSheet;
    private System.Windows.Forms.Button button_Cancel;
    private System.Windows.Forms.ComboBox comboBox_IBAN;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label_ExplanationList;
    private System.Windows.Forms.ComboBox comboBox_Explanation;
  }
}