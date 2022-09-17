namespace AssignmentNicoloRossi
{
    partial class FrmSearch
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
            this.CmBxColumn = new System.Windows.Forms.ComboBox();
            this.CmBxOperator = new System.Windows.Forms.ComboBox();
            this.TxBxValue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnRun = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CmBxColumn
            // 
            this.CmBxColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBxColumn.FormattingEnabled = true;
            this.CmBxColumn.Location = new System.Drawing.Point(25, 36);
            this.CmBxColumn.Name = "CmBxColumn";
            this.CmBxColumn.Size = new System.Drawing.Size(203, 37);
            this.CmBxColumn.TabIndex = 0;
            this.CmBxColumn.SelectedIndexChanged += new System.EventHandler(this.CmBxColumn_SelectedIndexChanged);
            // 
            // CmBxOperator
            // 
            this.CmBxOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmBxOperator.FormattingEnabled = true;
            this.CmBxOperator.Location = new System.Drawing.Point(284, 98);
            this.CmBxOperator.Name = "CmBxOperator";
            this.CmBxOperator.Size = new System.Drawing.Size(101, 37);
            this.CmBxOperator.TabIndex = 1;
            // 
            // TxBxValue
            // 
            this.TxBxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBxValue.Location = new System.Drawing.Point(412, 36);
            this.TxBxValue.Name = "TxBxValue";
            this.TxBxValue.Size = new System.Drawing.Size(119, 34);
            this.TxBxValue.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(756, 224);
            this.dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblValue);
            this.panel1.Controls.Add(this.lblOperator);
            this.panel1.Controls.Add(this.lblField);
            this.panel1.Controls.Add(this.CmBxColumn);
            this.panel1.Controls.Add(this.TxBxValue);
            this.panel1.Location = new System.Drawing.Point(13, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 121);
            this.panel1.TabIndex = 4;
            // 
            // BtnRun
            // 
            this.BtnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRun.Location = new System.Drawing.Point(614, 62);
            this.BtnRun.Name = "BtnRun";
            this.BtnRun.Size = new System.Drawing.Size(155, 58);
            this.BtnRun.TabIndex = 5;
            this.BtnRun.Text = "Run";
            this.BtnRun.UseVisualStyleBackColor = true;
            this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Location = new System.Drawing.Point(614, 125);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(155, 58);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LblInfo.Location = new System.Drawing.Point(12, 186);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(757, 23);
            this.LblInfo.TabIndex = 3;
            this.LblInfo.Click += new System.EventHandler(this.LblEngSize_Click);
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblField.Location = new System.Drawing.Point(75, 8);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(59, 25);
            this.lblField.TabIndex = 3;
            this.lblField.Text = "Field";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOperator.Location = new System.Drawing.Point(275, 8);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(97, 25);
            this.lblOperator.TabIndex = 4;
            this.lblOperator.Text = "Operator";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblValue.Location = new System.Drawing.Point(427, 8);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(68, 25);
            this.lblValue.TabIndex = 5;
            this.lblValue.Text = "Value";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSearch.Location = new System.Drawing.Point(23, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(177, 36);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search car:";
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnRun);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CmBxOperator);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSearch";
            this.Text = "Task A Search Nicolo Rossi 02/03/2022";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmBxColumn;
        private System.Windows.Forms.ComboBox CmBxOperator;
        private System.Windows.Forms.TextBox TxBxValue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRun;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblSearch;
    }
}