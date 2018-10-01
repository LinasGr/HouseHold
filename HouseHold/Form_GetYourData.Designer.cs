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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button_Close = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 29);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(581, 150);
      this.dataGridView1.TabIndex = 1;
      // 
      // button_Close
      // 
      this.button_Close.Location = new System.Drawing.Point(264, 197);
      this.button_Close.Name = "button_Close";
      this.button_Close.Size = new System.Drawing.Size(75, 23);
      this.button_Close.TabIndex = 2;
      this.button_Close.Text = "Close";
      this.button_Close.UseVisualStyleBackColor = true;
      this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
      // 
      // FormGetYourData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(605, 235);
      this.Controls.Add(this.button_Close);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.label_UserName);
      this.Name = "FormGetYourData";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "HouseHold Get Your Data";
      this.Load += new System.EventHandler(this.Form_GetYourData_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_UserName;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button_Close;
  }
}