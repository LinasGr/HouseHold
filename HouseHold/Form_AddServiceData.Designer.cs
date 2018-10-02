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
      this.numericUpDown_DayCounter = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown_NiteCounter = new System.Windows.Forms.NumericUpDown();
      this.numericUpDown_SingleCounter = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DayCounter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NiteCounter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SingleCounter)).BeginInit();
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
      this.button_PushToSheet.Location = new System.Drawing.Point(39, 151);
      this.button_PushToSheet.Name = "button_PushToSheet";
      this.button_PushToSheet.Size = new System.Drawing.Size(100, 23);
      this.button_PushToSheet.TabIndex = 10;
      this.button_PushToSheet.Text = "Push to sheet";
      this.button_PushToSheet.UseVisualStyleBackColor = true;
      // 
      // button_Close
      // 
      this.button_Close.Location = new System.Drawing.Point(145, 151);
      this.button_Close.Name = "button_Close";
      this.button_Close.Size = new System.Drawing.Size(100, 23);
      this.button_Close.TabIndex = 11;
      this.button_Close.Text = "Close";
      this.button_Close.UseVisualStyleBackColor = true;
      this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
      // 
      // numericUpDown_DayCounter
      // 
      this.numericUpDown_DayCounter.DecimalPlaces = 2;
      this.numericUpDown_DayCounter.Location = new System.Drawing.Point(109, 64);
      this.numericUpDown_DayCounter.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
      this.numericUpDown_DayCounter.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
      this.numericUpDown_DayCounter.Name = "numericUpDown_DayCounter";
      this.numericUpDown_DayCounter.Size = new System.Drawing.Size(150, 20);
      this.numericUpDown_DayCounter.TabIndex = 12;
      // 
      // numericUpDown_NiteCounter
      // 
      this.numericUpDown_NiteCounter.DecimalPlaces = 2;
      this.numericUpDown_NiteCounter.Location = new System.Drawing.Point(109, 90);
      this.numericUpDown_NiteCounter.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
      this.numericUpDown_NiteCounter.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
      this.numericUpDown_NiteCounter.Name = "numericUpDown_NiteCounter";
      this.numericUpDown_NiteCounter.Size = new System.Drawing.Size(150, 20);
      this.numericUpDown_NiteCounter.TabIndex = 13;
      // 
      // numericUpDown_SingleCounter
      // 
      this.numericUpDown_SingleCounter.DecimalPlaces = 2;
      this.numericUpDown_SingleCounter.Location = new System.Drawing.Point(109, 116);
      this.numericUpDown_SingleCounter.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
      this.numericUpDown_SingleCounter.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
      this.numericUpDown_SingleCounter.Name = "numericUpDown_SingleCounter";
      this.numericUpDown_SingleCounter.Size = new System.Drawing.Size(150, 20);
      this.numericUpDown_SingleCounter.TabIndex = 14;
      // 
      // Form_AddServiceData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(280, 200);
      this.ControlBox = false;
      this.Controls.Add(this.numericUpDown_SingleCounter);
      this.Controls.Add(this.numericUpDown_NiteCounter);
      this.Controls.Add(this.numericUpDown_DayCounter);
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
      this.Name = "Form_AddServiceData";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "HouseHold Add Service Data";
      this.Load += new System.EventHandler(this.Form_AddServiceData_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DayCounter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NiteCounter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SingleCounter)).EndInit();
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
    private System.Windows.Forms.NumericUpDown numericUpDown_DayCounter;
    private System.Windows.Forms.NumericUpDown numericUpDown_NiteCounter;
    private System.Windows.Forms.NumericUpDown numericUpDown_SingleCounter;
  }
}