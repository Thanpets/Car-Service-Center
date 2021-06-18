
namespace CarServiceCenter.WUI {
    partial class TransactionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ctrlDateLabel = new System.Windows.Forms.Label();
            this.ctrlCustomerIDLabel = new System.Windows.Forms.Label();
            this.ctrlCarIDLabel = new System.Windows.Forms.Label();
            this.ctrlTransactionLinesLabel = new System.Windows.Forms.Label();
            this.ctrlHoursLabel = new System.Windows.Forms.Label();
            this.ctrlDate = new System.Windows.Forms.DateTimePicker();
            this.ctrlCustomers = new System.Windows.Forms.ListBox();
            this.ctrlCars = new System.Windows.Forms.ListBox();
            this.ctrlTransactionLines = new System.Windows.Forms.CheckedListBox();
            this.ctrlHours = new System.Windows.Forms.NumericUpDown();
            this.ctrlOK = new System.Windows.Forms.Button();
            this.ctrlCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDateLabel
            // 
            this.ctrlDateLabel.AutoSize = true;
            this.ctrlDateLabel.Location = new System.Drawing.Point(33, 71);
            this.ctrlDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlDateLabel.Name = "ctrlDateLabel";
            this.ctrlDateLabel.Size = new System.Drawing.Size(30, 13);
            this.ctrlDateLabel.TabIndex = 0;
            this.ctrlDateLabel.Text = "Date";
            // 
            // ctrlCustomerIDLabel
            // 
            this.ctrlCustomerIDLabel.AutoSize = true;
            this.ctrlCustomerIDLabel.Location = new System.Drawing.Point(33, 128);
            this.ctrlCustomerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlCustomerIDLabel.Name = "ctrlCustomerIDLabel";
            this.ctrlCustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.ctrlCustomerIDLabel.TabIndex = 1;
            this.ctrlCustomerIDLabel.Text = "Customer ID";
            // 
            // ctrlCarIDLabel
            // 
            this.ctrlCarIDLabel.AutoSize = true;
            this.ctrlCarIDLabel.Location = new System.Drawing.Point(33, 220);
            this.ctrlCarIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlCarIDLabel.Name = "ctrlCarIDLabel";
            this.ctrlCarIDLabel.Size = new System.Drawing.Size(37, 13);
            this.ctrlCarIDLabel.TabIndex = 3;
            this.ctrlCarIDLabel.Text = "Car ID";
            // 
            // ctrlTransactionLinesLabel
            // 
            this.ctrlTransactionLinesLabel.AutoSize = true;
            this.ctrlTransactionLinesLabel.Location = new System.Drawing.Point(33, 344);
            this.ctrlTransactionLinesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlTransactionLinesLabel.Name = "ctrlTransactionLinesLabel";
            this.ctrlTransactionLinesLabel.Size = new System.Drawing.Size(87, 13);
            this.ctrlTransactionLinesLabel.TabIndex = 2;
            this.ctrlTransactionLinesLabel.Text = "Transaction lines";
            // 
            // ctrlHoursLabel
            // 
            this.ctrlHoursLabel.AutoSize = true;
            this.ctrlHoursLabel.Location = new System.Drawing.Point(33, 445);
            this.ctrlHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlHoursLabel.Name = "ctrlHoursLabel";
            this.ctrlHoursLabel.Size = new System.Drawing.Size(35, 13);
            this.ctrlHoursLabel.TabIndex = 5;
            this.ctrlHoursLabel.Text = "Hours";
            // 
            // ctrlDate
            // 
            this.ctrlDate.Location = new System.Drawing.Point(214, 67);
            this.ctrlDate.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlDate.Name = "ctrlDate";
            this.ctrlDate.Size = new System.Drawing.Size(305, 20);
            this.ctrlDate.TabIndex = 6;
            // 
            // ctrlCustomers
            // 
            this.ctrlCustomers.FormattingEnabled = true;
            this.ctrlCustomers.Location = new System.Drawing.Point(213, 114);
            this.ctrlCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlCustomers.Name = "ctrlCustomers";
            this.ctrlCustomers.Size = new System.Drawing.Size(306, 82);
            this.ctrlCustomers.TabIndex = 7;
            // 
            // ctrlCars
            // 
            this.ctrlCars.FormattingEnabled = true;
            this.ctrlCars.Location = new System.Drawing.Point(213, 212);
            this.ctrlCars.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlCars.Name = "ctrlCars";
            this.ctrlCars.Size = new System.Drawing.Size(306, 82);
            this.ctrlCars.TabIndex = 8;
            // 
            // ctrlTransactionLines
            // 
            this.ctrlTransactionLines.CheckOnClick = true;
            this.ctrlTransactionLines.FormattingEnabled = true;
            this.ctrlTransactionLines.Location = new System.Drawing.Point(214, 335);
            this.ctrlTransactionLines.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlTransactionLines.Name = "ctrlTransactionLines";
            this.ctrlTransactionLines.Size = new System.Drawing.Size(301, 79);
            this.ctrlTransactionLines.TabIndex = 9;
            this.ctrlTransactionLines.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ctrlTransactionLines_ItemCheck);
         //   this.ctrlTransactionLines.Click += new System.EventHandler(this.ctrlTransactionLines_Click);
            this.ctrlTransactionLines.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctrlTransactionLines_MouseClick);
            // 
            // ctrlHours
            // 
            this.ctrlHours.Enabled = false;
            this.ctrlHours.Location = new System.Drawing.Point(213, 444);
            this.ctrlHours.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlHours.Name = "ctrlHours";
            this.ctrlHours.Size = new System.Drawing.Size(304, 20);
            this.ctrlHours.TabIndex = 10;
            this.ctrlHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ctrlOK
            // 
            this.ctrlOK.Location = new System.Drawing.Point(344, 507);
            this.ctrlOK.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(76, 31);
            this.ctrlOK.TabIndex = 11;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Location = new System.Drawing.Point(438, 507);
            this.ctrlCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(76, 31);
            this.ctrlCancel.TabIndex = 12;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.UseVisualStyleBackColor = true;
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 585);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOK);
            this.Controls.Add(this.ctrlHours);
            this.Controls.Add(this.ctrlTransactionLines);
            this.Controls.Add(this.ctrlCars);
            this.Controls.Add(this.ctrlCustomers);
            this.Controls.Add(this.ctrlDate);
            this.Controls.Add(this.ctrlHoursLabel);
            this.Controls.Add(this.ctrlCarIDLabel);
            this.Controls.Add(this.ctrlTransactionLinesLabel);
            this.Controls.Add(this.ctrlCustomerIDLabel);
            this.Controls.Add(this.ctrlDateLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransactionForm";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctrlDateLabel;
        private System.Windows.Forms.Label ctrlCustomerIDLabel;
        private System.Windows.Forms.Label ctrlCarIDLabel;
        private System.Windows.Forms.Label ctrlTransactionLinesLabel;
        private System.Windows.Forms.Label ctrlHoursLabel;
        private System.Windows.Forms.DateTimePicker ctrlDate;
        private System.Windows.Forms.ListBox ctrlCustomers;
        private System.Windows.Forms.ListBox ctrlCars;
        private System.Windows.Forms.CheckedListBox ctrlTransactionLines;
        private System.Windows.Forms.NumericUpDown ctrlHours;
        private System.Windows.Forms.Button ctrlOK;
        private System.Windows.Forms.Button ctrlCancel;
    }
}