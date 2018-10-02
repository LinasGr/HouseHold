namespace HouseHold
{
  partial class FormSetupSheet
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
      this.button_Load = new System.Windows.Forms.Button();
      this.dataGridView_Setup = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Setup)).BeginInit();
      this.SuspendLayout();
      // 
      // label_Name
      // 
      this.label_Name.AutoSize = true;
      this.label_Name.Location = new System.Drawing.Point(59, 41);
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
      this.textBox_SheetID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox_SheetID.Location = new System.Drawing.Point(100, 12);
      this.textBox_SheetID.Name = "textBox_SheetID";
      this.textBox_SheetID.Size = new System.Drawing.Size(511, 20);
      this.textBox_SheetID.TabIndex = 3;
      this.textBox_SheetID.TextChanged += new System.EventHandler(this.SheetIdRegex);
      // 
      // label_SheetID
      // 
      this.label_SheetID.AutoSize = true;
      this.label_SheetID.Location = new System.Drawing.Point(14, 19);
      this.label_SheetID.Name = "label_SheetID";
      this.label_SheetID.Size = new System.Drawing.Size(80, 13);
      this.label_SheetID.TabIndex = 2;
      this.label_SheetID.Text = "SpreadSheetID";
      // 
      // button_OK
      // 
      this.button_OK.Location = new System.Drawing.Point(100, 226);
      this.button_OK.Name = "button_OK";
      this.button_OK.Size = new System.Drawing.Size(75, 23);
      this.button_OK.TabIndex = 4;
      this.button_OK.Text = "OK";
      this.button_OK.UseVisualStyleBackColor = true;
      this.button_OK.Click += new System.EventHandler(this.Button_OK_Click);
      // 
      // button_Cancel
      // 
      this.button_Cancel.Location = new System.Drawing.Point(262, 226);
      this.button_Cancel.Name = "button_Cancel";
      this.button_Cancel.Size = new System.Drawing.Size(75, 23);
      this.button_Cancel.TabIndex = 5;
      this.button_Cancel.Text = "Close";
      this.button_Cancel.UseVisualStyleBackColor = true;
      this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
      // 
      // button_Load
      // 
      this.button_Load.Location = new System.Drawing.Point(181, 226);
      this.button_Load.Name = "button_Load";
      this.button_Load.Size = new System.Drawing.Size(75, 23);
      this.button_Load.TabIndex = 6;
      this.button_Load.Text = "Load data";
      this.button_Load.UseVisualStyleBackColor = true;
      this.button_Load.Click += new System.EventHandler(this.Button_Save_Click);
      // 
      // dataGridView_Setup
      // 
      this.dataGridView_Setup.AllowUserToAddRows = false;
      this.dataGridView_Setup.AllowUserToDeleteRows = false;
      this.dataGridView_Setup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dataGridView_Setup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView_Setup.Location = new System.Drawing.Point(100, 64);
      this.dataGridView_Setup.Name = "dataGridView_Setup";
      this.dataGridView_Setup.ReadOnly = true;
      this.dataGridView_Setup.Size = new System.Drawing.Size(511, 144);
      this.dataGridView_Setup.TabIndex = 7;
      this.dataGridView_Setup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Setup_CellContentClick);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(41, 122);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 13);
      this.label1.TabIndex = 8;
      this.label1.Text = "User data";
      this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // FormSetupSheet
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(643, 270);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.dataGridView_Setup);
      this.Controls.Add(this.button_Load);
      this.Controls.Add(this.button_Cancel);
      this.Controls.Add(this.button_OK);
      this.Controls.Add(this.textBox_SheetID);
      this.Controls.Add(this.label_SheetID);
      this.Controls.Add(this.textBox_Name);
      this.Controls.Add(this.label_Name);
      this.Name = "FormSetupSheet";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "HouseHold sheet setup";
      this.Load += new System.EventHandler(this.Form_SetupSheet_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Setup)).EndInit();
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
    private System.Windows.Forms.Button button_Load;
    private System.Windows.Forms.DataGridView dataGridView_Setup;
    private System.Windows.Forms.Label label1;
  }
}