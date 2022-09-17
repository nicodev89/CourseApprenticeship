namespace AssignmentNicoloRossi
{
    partial class frmCars
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
            this.components = new System.ComponentModel.Container();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblEngine = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAvailability = new System.Windows.Forms.Label();
            this.TxBRegistNum = new System.Windows.Forms.TextBox();
            this.TxBMake = new System.Windows.Forms.TextBox();
            this.TxBEngine = new System.Windows.Forms.TextBox();
            this.TxBPrice = new System.Windows.Forms.TextBox();
            this.CbxAvailability = new System.Windows.Forms.CheckBox();
            this.DtTPkDate = new System.Windows.Forms.DateTimePicker();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.BtnPrev = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.LblRecordNofN = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegNum.Location = new System.Drawing.Point(12, 80);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(264, 25);
            this.lblRegNum.TabIndex = 2;
            this.lblRegNum.Text = "Vehicle Registration Number:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(12, 131);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(67, 25);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "Make:";
            // 
            // lblEngine
            // 
            this.lblEngine.AutoSize = true;
            this.lblEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngine.Location = new System.Drawing.Point(12, 179);
            this.lblEngine.Name = "lblEngine";
            this.lblEngine.Size = new System.Drawing.Size(123, 25);
            this.lblEngine.TabIndex = 2;
            this.lblEngine.Text = "Engine Size:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(12, 231);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(150, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date registered:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(15, 279);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(143, 25);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Rental per day:";
            // 
            // lblAvailability
            // 
            this.lblAvailability.AutoSize = true;
            this.lblAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailability.Location = new System.Drawing.Point(15, 332);
            this.lblAvailability.Name = "lblAvailability";
            this.lblAvailability.Size = new System.Drawing.Size(98, 25);
            this.lblAvailability.TabIndex = 5;
            this.lblAvailability.Text = "Available:";
            // 
            // TxBRegistNum
            // 
            this.TxBRegistNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBRegistNum.Location = new System.Drawing.Point(303, 80);
            this.TxBRegistNum.Name = "TxBRegistNum";
            this.TxBRegistNum.Size = new System.Drawing.Size(180, 30);
            this.TxBRegistNum.TabIndex = 0;
            this.toolTip1.SetToolTip(this.TxBRegistNum, "Insert Reg. No of the car (8 characters)");
            // 
            // TxBMake
            // 
            this.TxBMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBMake.Location = new System.Drawing.Point(303, 131);
            this.TxBMake.Name = "TxBMake";
            this.TxBMake.Size = new System.Drawing.Size(180, 30);
            this.TxBMake.TabIndex = 1;
            this.toolTip1.SetToolTip(this.TxBMake, "Insert Make of car");
            // 
            // TxBEngine
            // 
            this.TxBEngine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBEngine.Location = new System.Drawing.Point(303, 179);
            this.TxBEngine.Name = "TxBEngine";
            this.TxBEngine.Size = new System.Drawing.Size(110, 30);
            this.TxBEngine.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TxBEngine, "Insert Engine size for this car");
            // 
            // TxBPrice
            // 
            this.TxBPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxBPrice.Location = new System.Drawing.Point(303, 279);
            this.TxBPrice.Name = "TxBPrice";
            this.TxBPrice.Size = new System.Drawing.Size(180, 30);
            this.TxBPrice.TabIndex = 4;
            this.toolTip1.SetToolTip(this.TxBPrice, "Insert Price per day");
            // 
            // CbxAvailability
            // 
            this.CbxAvailability.AutoSize = true;
            this.CbxAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxAvailability.Location = new System.Drawing.Point(303, 337);
            this.CbxAvailability.Name = "CbxAvailability";
            this.CbxAvailability.Size = new System.Drawing.Size(18, 17);
            this.CbxAvailability.TabIndex = 5;
            this.toolTip1.SetToolTip(this.CbxAvailability, "Ticked if available");
            this.CbxAvailability.UseVisualStyleBackColor = true;
            // 
            // DtTPkDate
            // 
            this.DtTPkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtTPkDate.Location = new System.Drawing.Point(303, 224);
            this.DtTPkDate.Name = "DtTPkDate";
            this.DtTPkDate.Size = new System.Drawing.Size(344, 30);
            this.DtTPkDate.TabIndex = 3;
            this.toolTip1.SetToolTip(this.DtTPkDate, "Select Date car was registered ");
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(674, 55);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(114, 55);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "&Update";
            this.toolTip1.SetToolTip(this.BtnUpdate, "Click this to Update the data of the car");
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(674, 116);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(114, 55);
            this.BtnAdd.TabIndex = 11;
            this.BtnAdd.Text = "&Add";
            this.toolTip1.SetToolTip(this.BtnAdd, "Click to add the car to the Database");
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(674, 179);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 55);
            this.BtnDelete.TabIndex = 12;
            this.BtnDelete.Text = "&Delete";
            this.toolTip1.SetToolTip(this.BtnDelete, "Click to Delete the car from Database");
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(674, 399);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(114, 61);
            this.BtnExit.TabIndex = 15;
            this.BtnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.BtnExit, "Exit application");
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(674, 301);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(114, 55);
            this.BtnCancel.TabIndex = 14;
            this.BtnCancel.Text = "&Cancel";
            this.toolTip1.SetToolTip(this.BtnCancel, "Cancel all changes made");
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.Location = new System.Drawing.Point(674, 240);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(114, 55);
            this.BtnSearch.TabIndex = 13;
            this.BtnSearch.Text = "&Search";
            this.toolTip1.SetToolTip(this.BtnSearch, "This open a pannel to search in Database");
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFirst.Location = new System.Drawing.Point(70, 399);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(87, 61);
            this.BtnFirst.TabIndex = 6;
            this.BtnFirst.Text = "First";
            this.toolTip1.SetToolTip(this.BtnFirst, "Visualize first car on the list");
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrev.Location = new System.Drawing.Point(163, 399);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Size = new System.Drawing.Size(113, 61);
            this.BtnPrev.TabIndex = 7;
            this.BtnPrev.Text = "Previous";
            this.toolTip1.SetToolTip(this.BtnPrev, "Visualize previous car");
            this.BtnPrev.UseVisualStyleBackColor = true;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(422, 399);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(122, 61);
            this.BtnNext.TabIndex = 8;
            this.BtnNext.Text = "Next";
            this.toolTip1.SetToolTip(this.BtnNext, "Visualize next car");
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLast.Location = new System.Drawing.Point(550, 399);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(87, 61);
            this.BtnLast.TabIndex = 9;
            this.BtnLast.Text = "Last";
            this.toolTip1.SetToolTip(this.BtnLast, "Visualize Last car of the list");
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(221, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 36);
            this.lblTitle.TabIndex = 23;
            this.lblTitle.Text = "Bowman Car Hire";
            // 
            // LblRecordNofN
            // 
            this.LblRecordNofN.AutoSize = true;
            this.LblRecordNofN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecordNofN.Location = new System.Drawing.Point(311, 414);
            this.LblRecordNofN.Name = "LblRecordNofN";
            this.LblRecordNofN.Size = new System.Drawing.Size(71, 29);
            this.LblRecordNofN.TabIndex = 24;
            this.LblRecordNofN.Text = "0 of 0";
            // 
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.LblRecordNofN);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnFirst);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.DtTPkDate);
            this.Controls.Add(this.CbxAvailability);
            this.Controls.Add(this.TxBPrice);
            this.Controls.Add(this.TxBEngine);
            this.Controls.Add(this.TxBMake);
            this.Controls.Add(this.TxBRegistNum);
            this.Controls.Add(this.lblAvailability);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblEngine);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblRegNum);
            this.Name = "frmCars";
            this.Text = "Task A Nicolo Rossi 02/03/2022";
            this.Load += new System.EventHandler(this.frmCars_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblEngine;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAvailability;
        private System.Windows.Forms.TextBox TxBRegistNum;
        private System.Windows.Forms.TextBox TxBMake;
        private System.Windows.Forms.TextBox TxBEngine;
        private System.Windows.Forms.TextBox TxBPrice;
        private System.Windows.Forms.CheckBox CbxAvailability;
        private System.Windows.Forms.DateTimePicker DtTPkDate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnPrev;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label LblRecordNofN;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

