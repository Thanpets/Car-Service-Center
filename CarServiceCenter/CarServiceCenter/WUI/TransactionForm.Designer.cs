
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
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlDateLabel
            // 
            this.ctrlDateLabel.AutoSize = true;
            this.ctrlDateLabel.Location = new System.Drawing.Point(44, 87);
            this.ctrlDateLabel.Name = "ctrlDateLabel";
            this.ctrlDateLabel.Size = new System.Drawing.Size(38, 17);
            this.ctrlDateLabel.TabIndex = 0;
            this.ctrlDateLabel.Text = "Date";
            // 
            // ctrlCustomerIDLabel
            // 
            this.ctrlCustomerIDLabel.AutoSize = true;
            this.ctrlCustomerIDLabel.Location = new System.Drawing.Point(44, 157);
            this.ctrlCustomerIDLabel.Name = "ctrlCustomerIDLabel";
            this.ctrlCustomerIDLabel.Size = new System.Drawing.Size(85, 17);
            this.ctrlCustomerIDLabel.TabIndex = 1;
            this.ctrlCustomerIDLabel.Text = "Customer ID";
            // 
            // ctrlCarIDLabel
            // 
            this.ctrlCarIDLabel.AutoSize = true;
            this.ctrlCarIDLabel.Location = new System.Drawing.Point(44, 271);
            this.ctrlCarIDLabel.Name = "ctrlCarIDLabel";
            this.ctrlCarIDLabel.Size = new System.Drawing.Size(47, 17);
            this.ctrlCarIDLabel.TabIndex = 3;
            this.ctrlCarIDLabel.Text = "Car ID";
            // 
            // ctrlTransactionLinesLabel
            // 
            this.ctrlTransactionLinesLabel.AutoSize = true;
            this.ctrlTransactionLinesLabel.Location = new System.Drawing.Point(44, 423);
            this.ctrlTransactionLinesLabel.Name = "ctrlTransactionLinesLabel";
            this.ctrlTransactionLinesLabel.Size = new System.Drawing.Size(116, 17);
            this.ctrlTransactionLinesLabel.TabIndex = 2;
            this.ctrlTransactionLinesLabel.Text = "Transaction lines";
            // 
            // ctrlHoursLabel
            // 
            this.ctrlHoursLabel.AutoSize = true;
            this.ctrlHoursLabel.Location = new System.Drawing.Point(44, 548);
            this.ctrlHoursLabel.Name = "ctrlHoursLabel";
            this.ctrlHoursLabel.Size = new System.Drawing.Size(46, 17);
            this.ctrlHoursLabel.TabIndex = 5;
            this.ctrlHoursLabel.Text = "Hours";
            // 
            // ctrlDate
            // 
            this.ctrlDate.Location = new System.Drawing.Point(285, 82);
            this.ctrlDate.Name = "ctrlDate";
            this.ctrlDate.Size = new System.Drawing.Size(405, 22);
            this.ctrlDate.TabIndex = 6;
            // 
            // ctrlCustomers
            // 
            this.ctrlCustomers.FormattingEnabled = true;
            this.ctrlCustomers.ItemHeight = 16;
            this.ctrlCustomers.Location = new System.Drawing.Point(284, 140);
            this.ctrlCustomers.Name = "ctrlCustomers";
            this.ctrlCustomers.Size = new System.Drawing.Size(406, 100);
            this.ctrlCustomers.TabIndex = 7;
            // 
            // ctrlCars
            // 
            this.ctrlCars.FormattingEnabled = true;
            this.ctrlCars.ItemHeight = 16;
            this.ctrlCars.Location = new System.Drawing.Point(284, 261);
            this.ctrlCars.Name = "ctrlCars";
            this.ctrlCars.Size = new System.Drawing.Size(406, 100);
            this.ctrlCars.TabIndex = 8;
            // 
            // ctrlTransactionLines
            // 
            this.ctrlTransactionLines.FormattingEnabled = true;
            this.ctrlTransactionLines.Location = new System.Drawing.Point(285, 412);
            this.ctrlTransactionLines.Name = "ctrlTransactionLines";
            this.ctrlTransactionLines.Size = new System.Drawing.Size(400, 106);
            this.ctrlTransactionLines.TabIndex = 9;
            // 
            // ctrlHours
            // 
            this.ctrlHours.Location = new System.Drawing.Point(284, 546);
            this.ctrlHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlHours.Name = "ctrlHours";
            this.ctrlHours.Size = new System.Drawing.Size(406, 22);
            this.ctrlHours.TabIndex = 10;
            this.ctrlHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ctrlOK
            // 
            this.ctrlOK.Location = new System.Drawing.Point(458, 624);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(101, 38);
            this.ctrlOK.TabIndex = 11;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 624);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 38);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 720);
            this.Controls.Add(this.button2);
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
            this.Name = "Transaction";
            this.Text = "Transaction";
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
        private System.Windows.Forms.Button button2;
    }
}