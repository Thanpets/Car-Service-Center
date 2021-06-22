
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
            this.ctrlDate = new System.Windows.Forms.DateTimePicker();
            this.ctrlCustomers = new System.Windows.Forms.ListBox();
            this.ctrlCars = new System.Windows.Forms.ListBox();
            this.ctrlTransactionLines = new System.Windows.Forms.CheckedListBox();
            this.ctrlOK = new System.Windows.Forms.Button();
            this.ctrlCancel = new System.Windows.Forms.Button();
            this.ctrlAddNewTransactionLabel = new System.Windows.Forms.Label();
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
            this.ctrlCustomerIDLabel.Location = new System.Drawing.Point(44, 158);
            this.ctrlCustomerIDLabel.Name = "ctrlCustomerIDLabel";
            this.ctrlCustomerIDLabel.Size = new System.Drawing.Size(94, 17);
            this.ctrlCustomerIDLabel.TabIndex = 1;
            this.ctrlCustomerIDLabel.Text = "Customer TIN";
            // 
            // ctrlCarIDLabel
            // 
            this.ctrlCarIDLabel.AutoSize = true;
            this.ctrlCarIDLabel.Location = new System.Drawing.Point(44, 271);
            this.ctrlCarIDLabel.Name = "ctrlCarIDLabel";
            this.ctrlCarIDLabel.Size = new System.Drawing.Size(140, 17);
            this.ctrlCarIDLabel.TabIndex = 3;
            this.ctrlCarIDLabel.Text = "Car registration plate";
            // 
            // ctrlTransactionLinesLabel
            // 
            this.ctrlTransactionLinesLabel.AutoSize = true;
            this.ctrlTransactionLinesLabel.Location = new System.Drawing.Point(44, 395);
            this.ctrlTransactionLinesLabel.Name = "ctrlTransactionLinesLabel";
            this.ctrlTransactionLinesLabel.Size = new System.Drawing.Size(116, 17);
            this.ctrlTransactionLinesLabel.TabIndex = 2;
            this.ctrlTransactionLinesLabel.Text = "Transaction lines";
            // 
            // ctrlDate
            // 
            this.ctrlDate.Location = new System.Drawing.Point(285, 82);
            this.ctrlDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlDate.Name = "ctrlDate";
            this.ctrlDate.Size = new System.Drawing.Size(405, 22);
            this.ctrlDate.TabIndex = 6;
            // 
            // ctrlCustomers
            // 
            this.ctrlCustomers.FormattingEnabled = true;
            this.ctrlCustomers.ItemHeight = 16;
            this.ctrlCustomers.Location = new System.Drawing.Point(284, 140);
            this.ctrlCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlCustomers.Name = "ctrlCustomers";
            this.ctrlCustomers.Size = new System.Drawing.Size(407, 100);
            this.ctrlCustomers.TabIndex = 7;
            // 
            // ctrlCars
            // 
            this.ctrlCars.FormattingEnabled = true;
            this.ctrlCars.ItemHeight = 16;
            this.ctrlCars.Location = new System.Drawing.Point(284, 261);
            this.ctrlCars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlCars.Name = "ctrlCars";
            this.ctrlCars.Size = new System.Drawing.Size(407, 100);
            this.ctrlCars.TabIndex = 8;
            // 
            // ctrlTransactionLines
            // 
            this.ctrlTransactionLines.CheckOnClick = true;
            this.ctrlTransactionLines.FormattingEnabled = true;
            this.ctrlTransactionLines.HorizontalScrollbar = true;
            this.ctrlTransactionLines.Location = new System.Drawing.Point(285, 395);
            this.ctrlTransactionLines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlTransactionLines.Name = "ctrlTransactionLines";
            this.ctrlTransactionLines.ScrollAlwaysVisible = true;
            this.ctrlTransactionLines.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ctrlTransactionLines.Size = new System.Drawing.Size(400, 123);
            this.ctrlTransactionLines.TabIndex = 9;
            this.ctrlTransactionLines.ThreeDCheckBoxes = true;
            this.ctrlTransactionLines.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctrlTransactionLines_MouseClick);
            // 
            // ctrlOK
            // 
            this.ctrlOK.Location = new System.Drawing.Point(459, 589);
            this.ctrlOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(101, 38);
            this.ctrlOK.TabIndex = 11;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Location = new System.Drawing.Point(584, 589);
            this.ctrlCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(101, 38);
            this.ctrlCancel.TabIndex = 12;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.UseVisualStyleBackColor = true;
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // ctrlAddNewTransactionLabel
            // 
            this.ctrlAddNewTransactionLabel.AutoSize = true;
            this.ctrlAddNewTransactionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlAddNewTransactionLabel.Location = new System.Drawing.Point(45, 24);
            this.ctrlAddNewTransactionLabel.Name = "ctrlAddNewTransactionLabel";
            this.ctrlAddNewTransactionLabel.Size = new System.Drawing.Size(269, 29);
            this.ctrlAddNewTransactionLabel.TabIndex = 13;
            this.ctrlAddNewTransactionLabel.Text = "Add new transaction...";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 675);
            this.Controls.Add(this.ctrlAddNewTransactionLabel);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOK);
            this.Controls.Add(this.ctrlTransactionLines);
            this.Controls.Add(this.ctrlCars);
            this.Controls.Add(this.ctrlCustomers);
            this.Controls.Add(this.ctrlDate);
            this.Controls.Add(this.ctrlCarIDLabel);
            this.Controls.Add(this.ctrlTransactionLinesLabel);
            this.Controls.Add(this.ctrlCustomerIDLabel);
            this.Controls.Add(this.ctrlDateLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TransactionForm";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctrlDateLabel;
        private System.Windows.Forms.Label ctrlCustomerIDLabel;
        private System.Windows.Forms.Label ctrlCarIDLabel;
        private System.Windows.Forms.Label ctrlTransactionLinesLabel;
        private System.Windows.Forms.DateTimePicker ctrlDate;
        private System.Windows.Forms.ListBox ctrlCustomers;
        private System.Windows.Forms.ListBox ctrlCars;
        private System.Windows.Forms.CheckedListBox ctrlTransactionLines;
        private System.Windows.Forms.Button ctrlOK;
        private System.Windows.Forms.Button ctrlCancel;
        private System.Windows.Forms.Label ctrlAddNewTransactionLabel;
    }
}