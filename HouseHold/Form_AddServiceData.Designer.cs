namespace HouseHold
{
  partial class Form_AddServiceData
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
      this.comboBox_Services = new System.Windows.Forms.ComboBox();
      this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
      this.label_Service = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.button_PushToSheet = new System.Windows.Forms.Button();
      this.button_Close = new System.Windows.Forms.Button();
      this.button_LoadLastServiceData = new System.Windows.Forms.Button();
      this.textBox_DayCounter = new System.Windows.Forms.TextBox();
      this.textBox_NiteCounter = new System.Windows.Forms.TextBox();
      this.textBox_SingleCounter = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // comboBox_Services
      // 
      this.comboBox_Services.FormattingEnabled = true;
      this.comboBox_Services.Location = new System.Drawing.Point(109, 9);
      this.comboBox_Services.Name = "comboBox_Services";
      this.comboBox_Services.Size = new System.Drawing.Size(150, 21);
      this.comboBox_Services.TabIndex = 0;
      this.comboBox_Services.SelectedIndexChanged += new System.EventHandler(this.comboBox_Services_SelectedIndexChanged);
      // 
      // dateTimePicker1
      // 
      this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker1.Location = new System.Drawing.Point(109, 36);
      this.dateTimePicker1.Name = "dateTimePicker1";
      this.dateTimePicker1.Size = new System.Drawing.Size(150, 20);
      this.dateTimePicker1.TabIndex = 1;
      this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
      // 
      // label_Service
      // 
      this.label_Service.AutoSize = true;
      this.label_Service.Location = new System.Drawing.Point(12, 9);
      this.label_Service.Name = "label_Service";
      this.label_Service.Size = new System.Drawing.Size(43, 13);
      this.label_Service.TabIndex = 5;
      this.label_Service.Text = "Service";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 39);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "Date";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 66);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(87, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Day time counter";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(12, 92);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(87, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Nite time counter";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 118);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(75, 13);
      this.label5.TabIndex = 9;
      this.label5.Text = "Single counter";
      // 
      // button_PushToSheet
      // 
      this.button_PushToSheet.BackColor = System.Drawing.Color.Yellow;
      this.button_PushToSheet.Location = new System.Drawing.Point(39, 151);
      this.button_PushToSheet.Name = "button_PushToSheet";
      this.button_PushToSheet.Size = new System.Drawing.Size(100, 23);
      this.button_PushToSheet.TabIndex = 10;
      this.button_PushToSheet.Text = "Push to sheet";
      this.button_PushToSheet.UseVisualStyleBackColor = false;
      this.button_PushToSheet.Click += new System.EventHandler(this.button_PushToSheet_Click);
      // 
      // button_Close
      // 
      this.button_Close.BackColor = System.Drawing.Color.Lime;
      this.button_Close.Location = new System.Drawing.Point(145, 151);
      this.button_Close.Name = "button_Close";
      this.button_Close.Size = new System.Drawing.Size(100, 23);
      this.button_Close.TabIndex = 11;
      this.button_Close.Text = "Close";
      this.button_Close.UseVisualStyleBackColor = false;
      this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
      // 
      // button_LoadLastServiceData
      // 
      this.button_LoadLastServiceData.BackColor = System.Drawing.Color.Lime;
      this.button_LoadLastServiceData.Location = new System.Drawing.Point(39, 180);
      this.button_LoadLastServiceData.Name = "button_LoadLastServiceData";
      this.button_LoadLastServiceData.Size = new System.Drawing.Size(206, 23);
      this.button_LoadLastServiceData.TabIndex = 15;
      this.button_LoadLastServiceData.Text = "Load last service data";
      this.button_LoadLastServiceData.UseVisualStyleBackColor = false;
      this.button_LoadLastServiceData.Click += new System.EventHandler(this.button_LoadLastServiceData_Click);
      // 
      // textBox_DayCounter
      // 
      this.textBox_DayCounter.Location = new System.Drawing.Point(109, 63);
      this.textBox_DayCounter.Name = "textBox_DayCounter";
      this.textBox_DayCounter.Size = new System.Drawing.Size(150, 20);
      this.textBox_DayCounter.TabIndex = 16;
      // 
      // textBox_NiteCounter
      // 
      this.textBox_NiteCounter.Location = new System.Drawing.Point(109, 89);
      this.textBox_NiteCounter.Name = "textBox_NiteCounter";
      this.textBox_NiteCounter.Size = new System.Drawing.Size(150, 20);
      this.textBox_NiteCounter.TabIndex = 17;
      // 
      // textBox_SingleCounter
      // 
      this.textBox_SingleCounter.Location = new System.Drawing.Point(109, 115);
      this.textBox_SingleCounter.Name = "textBox_SingleCounter";
      this.textBox_SingleCounter.Size = new System.Drawing.Size(150, 20);
      this.textBox_SingleCounter.TabIndex = 18;
      // 
      // Form_AddServiceData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(280, 217);
      this.Controls.Add(this.textBox_SingleCounter);
      this.Controls.Add(this.textBox_NiteCounter);
      this.Controls.Add(this.textBox_DayCounter);
      this.Controls.Add(this.button_LoadLastServiceData);
      this.Controls.Add(this.button_Close);
      this.Controls.Add(this.button_PushToSheet);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label_Service);
      this.Controls.Add(this.dateTimePicker1);
      this.Controls.Add(this.comboBox_Services);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form_AddServiceData";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "HouseHold Add Service Data";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBox_Services;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;
    private System.Windows.Forms.Label label_Service;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button_PushToSheet;
    private System.Windows.Forms.Button button_Close;
    private System.Windows.Forms.Button button_LoadLastServiceData;
    private System.Windows.Forms.TextBox textBox_DayCounter;
    private System.Windows.Forms.TextBox textBox_NiteCounter;
    private System.Windows.Forms.TextBox textBox_SingleCounter;
  }
}