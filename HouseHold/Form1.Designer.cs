namespace HouseHold
{
  partial class Form1
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
      this.label_SelectFile = new System.Windows.Forms.Label();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.textBox_FileName = new System.Windows.Forms.TextBox();
      this.button_BrowseFile = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // label_SelectFile
      // 
      this.label_SelectFile.AutoSize = true;
      this.label_SelectFile.Location = new System.Drawing.Point(9, 23);
      this.label_SelectFile.Name = "label_SelectFile";
      this.label_SelectFile.Size = new System.Drawing.Size(56, 13);
      this.label_SelectFile.TabIndex = 0;
      this.label_SelectFile.Text = "Select file:";
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "1.csv";
      this.openFileDialog1.InitialDirectory = "\"E://\"";
      // 
      // textBox_FileName
      // 
      this.textBox_FileName.Location = new System.Drawing.Point(81, 23);
      this.textBox_FileName.Name = "textBox_FileName";
      this.textBox_FileName.Size = new System.Drawing.Size(454, 20);
      this.textBox_FileName.TabIndex = 1;
      // 
      // button_BrowseFile
      // 
      this.button_BrowseFile.Location = new System.Drawing.Point(541, 20);
      this.button_BrowseFile.Name = "button_BrowseFile";
      this.button_BrowseFile.Size = new System.Drawing.Size(75, 23);
      this.button_BrowseFile.TabIndex = 2;
      this.button_BrowseFile.Text = "Browse file";
      this.button_BrowseFile.UseVisualStyleBackColor = true;
      this.button_BrowseFile.Click += new System.EventHandler(this.button_BrowseFile_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 49);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(894, 372);
      this.dataGridView1.TabIndex = 3;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(918, 433);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button_BrowseFile);
      this.Controls.Add(this.textBox_FileName);
      this.Controls.Add(this.label_SelectFile);
      this.Name = "Form1";
      this.Text = "HouseHold";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label_SelectFile;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.TextBox textBox_FileName;
    private System.Windows.Forms.Button button_BrowseFile;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}

