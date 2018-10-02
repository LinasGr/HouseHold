namespace HouseHold
{
  partial class FormAddBankData
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
      this.button_PushToSheet = new System.Windows.Forms.Button();
      this.progressBar_Push = new System.Windows.Forms.ProgressBar();
      this.button_Cancel = new System.Windows.Forms.Button();
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
      this.openFileDialog1.Filter = "SwedBank|*.csv|SebBank|*.acc";
      this.openFileDialog1.InitialDirectory = "\"E://\"";
      // 
      // textBox_FileName
      // 
      this.textBox_FileName.Location = new System.Drawing.Point(81, 23);
      this.textBox_FileName.Name = "textBox_FileName";
      this.textBox_FileName.Size = new System.Drawing.Size(403, 20);
      this.textBox_FileName.TabIndex = 1;
      // 
      // button_BrowseFile
      // 
      this.button_BrowseFile.Location = new System.Drawing.Point(490, 20);
      this.button_BrowseFile.Name = "button_BrowseFile";
      this.button_BrowseFile.Size = new System.Drawing.Size(75, 23);
      this.button_BrowseFile.TabIndex = 2;
      this.button_BrowseFile.Text = "Browse file";
      this.button_BrowseFile.UseVisualStyleBackColor = true;
      this.button_BrowseFile.Click += new System.EventHandler(this.Button_BrowseFile_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToResizeColumns = false;
      this.dataGridView1.AllowUserToResizeRows = false;
      this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(12, 49);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(894, 372);
      this.dataGridView1.TabIndex = 3;
      // 
      // button_PushToSheet
      // 
      this.button_PushToSheet.Location = new System.Drawing.Point(571, 20);
      this.button_PushToSheet.Name = "button_PushToSheet";
      this.button_PushToSheet.Size = new System.Drawing.Size(97, 23);
      this.button_PushToSheet.TabIndex = 4;
      this.button_PushToSheet.Text = "Push to Sheet";
      this.button_PushToSheet.UseVisualStyleBackColor = true;
      this.button_PushToSheet.Click += new System.EventHandler(this.Button_PushToSheet_Click);
      // 
      // progressBar_Push
      // 
      this.progressBar_Push.Location = new System.Drawing.Point(674, 20);
      this.progressBar_Push.Name = "progressBar_Push";
      this.progressBar_Push.Size = new System.Drawing.Size(129, 23);
      this.progressBar_Push.TabIndex = 5;
      // 
      // button_Cancel
      // 
      this.button_Cancel.Location = new System.Drawing.Point(809, 20);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(97, 23);
      this.button_Cancel.TabIndex = 6;
      this.button_Cancel.Text = "Close";
      this.button_Cancel.UseVisualStyleBackColor = true;
      this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
      // 
      // FormAddBankData
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(918, 433);
      this.Controls.Add(this.button_Cancel);
      this.Controls.Add(this.progressBar_Push);
      this.Controls.Add(this.button_PushToSheet);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.button_BrowseFile);
      this.Controls.Add(this.textBox_FileName);
      this.Controls.Add(this.label_SelectFile);
      this.Name = "FormAddBankData";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "HouseHold";
      this.Load += new System.EventHandler(this.Form_AddBankData_Load);
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
    private System.Windows.Forms.Button button_PushToSheet;
    private System.Windows.Forms.ProgressBar progressBar_Push;
    private System.Windows.Forms.Button button_Cancel;
  }
}

