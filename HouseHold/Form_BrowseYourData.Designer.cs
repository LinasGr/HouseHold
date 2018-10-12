namespace HouseHold
{
  partial class FormGetYourData
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
      this.label_UserName = new System.Windows.Forms.Label();
      this.dataGridView_UserData = new System.Windows.Forms.DataGridView();
      this.dataGridView_ServiceData = new System.Windows.Forms.DataGridView();
      this.label_Services = new System.Windows.Forms.Label();
      this.label_From = new System.Windows.Forms.Label();
      this.label_Till = new System.Windows.Forms.Label();
      this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
      this.dateTimePicker_Till = new System.Windows.Forms.DateTimePicker();
      this.label_ServiceSelect = new System.Windows.Forms.Label();
      this.comboBox_Services = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox_DayCounter = new System.Windows.Forms.TextBox();
      this.textBox_NiteCounter = new System.Windows.Forms.TextBox();
      this.textBox_SingleCounter = new System.Windows.Forms.TextBox();
      this.textBox_Total = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.button_Close = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserData)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServiceData)).BeginInit();
      this.SuspendLayout();
      // 
      // label_UserName
      // 
      this.label_UserName.AutoSize = true;
      this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label_UserName.Location = new System.Drawing.Point(261, 9);
      this.label_UserName.Name = "label_UserName";
      this.label_UserName.Size = new System.Drawing.Size(83, 17);
      this.label_UserName.TabIndex = 0;
      this.label_UserName.Text = "UserName";
      // 
      // dataGridView_UserData
      // 
      this.dataGridView_UserData.AllowUserToAddRows = false;
      this.dataGridView_UserData.AllowUserToDeleteRows = false;
      this.dataGridView_UserData.AllowUserToResizeColumns = false;
      this.dataGridView_UserData.AllowUserToResizeRows = false;
      this.dataGridView_UserData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_UserData.Location = new System.Drawing.Point(12, 29);
      this.dataGridView_UserData.Name = "dataGridView_UserData";
      this.dataGridView_UserData.Size = new System.Drawing.Size(581, 150);
      this.dataGridView_UserData.TabIndex = 1;
      // 
      // dataGridView_ServiceData
      // 
      this.dataGridView_ServiceData.AllowUserToAddRows = false;
      this.dataGridView_ServiceData.AllowUserToDeleteRows = false;
      this.dataGridView_ServiceData.AllowUserToResizeColumns = false;
      this.dataGridView_ServiceData.AllowUserToResizeRows = false;
      this.dataGridView_ServiceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_ServiceData.Location = new System.Drawing.Point(12, 231);
      this.dataGridView_ServiceData.Name = "dataGridView_ServiceData";
      this.dataGridView_ServiceData.Size = new System.Drawing.Size(581, 150);
      this.dataGridView_ServiceData.TabIndex = 3;
      // 
      // label_Services
      // 
      this.label_Services.AutoSize = true;
      this.label_Services.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label_Services.Location = new System.Drawing.Point(261, 211);
      this.label_Services.Name = "label_Services";
      this.label_Services.Size = new System.Drawing.Size(70, 17);
      this.label_Services.TabIndex = 4;
      this.label_Services.Text = "ServicesCounters";
      // 
      // label_From
      // 
      this.label_From.AutoSize = true;
      this.label_From.Location = new System.Drawing.Point(11, 428);
      this.label_From.Name = "label_From";
      this.label_From.Size = new System.Drawing.Size(90, 13);
      this.label_From.TabIndex = 5;
      this.label_From.Text = "Starting from date";
      // 
      // label_Till
      // 
      this.label_Till.AutoSize = true;
      this.label_Till.Location = new System.Drawing.Point(57, 453);
      this.label_Till.Name = "label_Till";
      this.label_Till.Size = new System.Drawing.Size(44, 13);
      this.label_Till.TabIndex = 6;
      this.label_Till.Text = "Till date";
      // 
      // dateTimePicker_From
      // 
      this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker_From.Location = new System.Drawing.Point(107, 422);
      this.dateTimePicker_From.Name = "dateTimePicker_From";
      this.dateTimePicker_From.Size = new System.Drawing.Size(150, 20);
      this.dateTimePicker_From.TabIndex = 7;
      this.dateTimePicker_From.Value = new System.DateTime(2000, 1, 1, 8, 0, 0, 0);
      this.dateTimePicker_From.ValueChanged += new System.EventHandler(this.dateTimePicker_From_ValueChanged);
      // 
      // dateTimePicker_Till
      // 
      this.dateTimePicker_Till.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dateTimePicker_Till.Location = new System.Drawing.Point(107, 448);
      this.dateTimePicker_Till.Name = "dateTimePicker_Till";
      this.dateTimePicker_Till.Size = new System.Drawing.Size(150, 20);
      this.dateTimePicker_Till.TabIndex = 8;
      this.dateTimePicker_Till.ValueChanged += new System.EventHandler(this.dateTimePicker_Till_ValueChanged);
      // 
      // label_ServiceSelect
      // 
      this.label_ServiceSelect.AutoSize = true;
      this.label_ServiceSelect.Location = new System.Drawing.Point(28, 398);
      this.label_ServiceSelect.Name = "label_ServiceSelect";
      this.label_ServiceSelect.Size = new System.Drawing.Size(76, 13);
      this.label_ServiceSelect.TabIndex = 9;
      this.label_ServiceSelect.Text = "Select Service";
      // 
      // comboBox_Services
      // 
      this.comboBox_Services.FormattingEnabled = true;
      this.comboBox_Services.Location = new System.Drawing.Point(107, 395);
      this.comboBox_Services.Name = "comboBox_Services";
      this.comboBox_Services.Size = new System.Drawing.Size(150, 21);
      this.comboBox_Services.TabIndex = 10;
      this.comboBox_Services.SelectedIndexChanged += new System.EventHandler(this.comboBox_Services_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(311, 401);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(65, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Day counter";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(311, 427);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 13);
      this.label2.TabIndex = 12;
      this.label2.Text = "Nite counter";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(301, 452);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(75, 13);
      this.label3.TabIndex = 13;
      this.label3.Text = "Single counter";
      // 
      // textBox_DayCounter
      // 
      this.textBox_DayCounter.Enabled = false;
      this.textBox_DayCounter.Location = new System.Drawing.Point(382, 398);
      this.textBox_DayCounter.Name = "textBox_DayCounter";
      this.textBox_DayCounter.Size = new System.Drawing.Size(91, 20);
      this.textBox_DayCounter.TabIndex = 14;
      // 
      // textBox_NiteCounter
      // 
      this.textBox_NiteCounter.Enabled = false;
      this.textBox_NiteCounter.Location = new System.Drawing.Point(382, 424);
      this.textBox_NiteCounter.Name = "textBox_NiteCounter";
      this.textBox_NiteCounter.Size = new System.Drawing.Size(91, 20);
      this.textBox_NiteCounter.TabIndex = 15;
      // 
      // textBox_SingleCounter
      // 
      this.textBox_SingleCounter.Enabled = false;
      this.textBox_SingleCounter.Location = new System.Drawing.Point(382, 449);
      this.textBox_SingleCounter.Name = "textBox_SingleCounter";
      this.textBox_SingleCounter.Size = new System.Drawing.Size(91, 20);
      this.textBox_SingleCounter.TabIndex = 16;
      // 
      // textBox_Total
      // 
      this.textBox_Total.Enabled = false;
      this.textBox_Total.Location = new System.Drawing.Point(479, 422);
      this.textBox_Total.Name = "textBox_Total";
      this.textBox_Total.Size = new System.Drawing.Size(114, 20);
      this.textBox_Total.TabIndex = 17;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(518, 406);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(31, 13);
      this.label4.TabIndex = 18;
      this.label4.Text = "Total";
      // 
      // button_Close
      // 
      this.button_Close.BackColor = System.Drawing.Color.Lime;
      this.button_Close.Location = new System.Drawing.Point(499, 447);
      this.button_Close.Name = "button_Close";
      this.button_Close.Size = new System.Drawing.Size(75, 23);
      this.button_Close.TabIndex = 19;
      this.button_Close.Text = "Close";
      this.button_Close.UseVisualStyleBackColor = false;
      this.button_Close.Click += new System.EventHandler(this.button_Close_Click_1);
      // 
      // FormGetYourData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(605, 483);
      this.Controls.Add(this.button_Close);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.textBox_Total);
      this.Controls.Add(this.textBox_SingleCounter);
      this.Controls.Add(this.textBox_NiteCounter);
      this.Controls.Add(this.textBox_DayCounter);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.comboBox_Services);
      this.Controls.Add(this.label_ServiceSelect);
      this.Controls.Add(this.dateTimePicker_Till);
      this.Controls.Add(this.dateTimePicker_From);
      this.Controls.Add(this.label_Till);
      this.Controls.Add(this.label_From);
      this.Controls.Add(this.label_Services);
      this.Controls.Add(this.dataGridView_ServiceData);
      this.Controls.Add(this.dataGridView_UserData);
      this.Controls.Add(this.label_UserName);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FormGetYourData";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "HouseHold Browse Your  data";
      this.Load += new System.EventHandler(this.Form_GetYourData_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_UserData)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ServiceData)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_UserName;
    private System.Windows.Forms.DataGridView dataGridView_UserData;
    private System.Windows.Forms.DataGridView dataGridView_ServiceData;
    private System.Windows.Forms.Label label_Services;
    private System.Windows.Forms.Label label_From;
    private System.Windows.Forms.Label label_Till;
    private System.Windows.Forms.DateTimePicker dateTimePicker_From;
    private System.Windows.Forms.DateTimePicker dateTimePicker_Till;
    private System.Windows.Forms.Label label_ServiceSelect;
    private System.Windows.Forms.ComboBox comboBox_Services;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox_DayCounter;
    private System.Windows.Forms.TextBox textBox_NiteCounter;
    private System.Windows.Forms.TextBox textBox_SingleCounter;
    private System.Windows.Forms.TextBox textBox_Total;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button_Close;
  }
}