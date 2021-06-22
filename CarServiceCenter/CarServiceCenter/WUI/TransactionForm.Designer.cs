
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
            this.ctrlTransactionLines = new System.Windows.Forms.CheckedListBox();
            this.ctrlOK = new System.Windows.Forms.Button();
            this.ctrlCancel = new System.Windows.Forms.Button();
            this.ctrlAddNewTransactionLabel = new System.Windows.Forms.Label();
            this.ctrlCustomers = new System.Windows.Forms.ListView();
            this.ctrlCars = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // ctrlDateLabel
            // 
            this.ctrlDateLabel.AutoSize = true;
            this.ctrlDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlDateLabel.Location = new System.Drawing.Point(106, 72);
            this.ctrlDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlDateLabel.Name = "ctrlDateLabel";
            this.ctrlDateLabel.Size = new System.Drawing.Size(40, 16);
            this.ctrlDateLabel.TabIndex = 0;
            this.ctrlDateLabel.Text = "Date:";
            // 
            // ctrlCustomerIDLabel
            // 
            this.ctrlCustomerIDLabel.AutoSize = true;
            this.ctrlCustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCustomerIDLabel.Location = new System.Drawing.Point(62, 109);
            this.ctrlCustomerIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlCustomerIDLabel.Name = "ctrlCustomerIDLabel";
            this.ctrlCustomerIDLabel.Size = new System.Drawing.Size(84, 16);
            this.ctrlCustomerIDLabel.TabIndex = 1;
            this.ctrlCustomerIDLabel.Text = "Customer ID:";
            // 
            // ctrlCarIDLabel
            // 
            this.ctrlCarIDLabel.AutoSize = true;
            this.ctrlCarIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCarIDLabel.Location = new System.Drawing.Point(15, 238);
            this.ctrlCarIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlCarIDLabel.Name = "ctrlCarIDLabel";
            this.ctrlCarIDLabel.Size = new System.Drawing.Size(131, 16);
            this.ctrlCarIDLabel.TabIndex = 3;
            this.ctrlCarIDLabel.Text = "Car registration plate";
            // 
            // ctrlTransactionLinesLabel
            // 
            this.ctrlTransactionLinesLabel.AutoSize = true;
            this.ctrlTransactionLinesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlTransactionLinesLabel.Location = new System.Drawing.Point(33, 376);
            this.ctrlTransactionLinesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlTransactionLinesLabel.Name = "ctrlTransactionLinesLabel";
            this.ctrlTransactionLinesLabel.Size = new System.Drawing.Size(113, 16);
            this.ctrlTransactionLinesLabel.TabIndex = 2;
            this.ctrlTransactionLinesLabel.Text = "Transaction lines:";
            // 
            // ctrlDate
            // 
            this.ctrlDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlDate.Location = new System.Drawing.Point(214, 67);
            this.ctrlDate.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlDate.Name = "ctrlDate";
            this.ctrlDate.Size = new System.Drawing.Size(347, 22);
            this.ctrlDate.TabIndex = 6;
            // 
            // ctrlTransactionLines
            // 
            this.ctrlTransactionLines.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlTransactionLines.CheckOnClick = true;
            this.ctrlTransactionLines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlTransactionLines.FormattingEnabled = true;
            this.ctrlTransactionLines.HorizontalScrollbar = true;
            this.ctrlTransactionLines.Location = new System.Drawing.Point(214, 376);
            this.ctrlTransactionLines.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlTransactionLines.Name = "ctrlTransactionLines";
            this.ctrlTransactionLines.ScrollAlwaysVisible = true;
            this.ctrlTransactionLines.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ctrlTransactionLines.Size = new System.Drawing.Size(347, 106);
            this.ctrlTransactionLines.TabIndex = 9;
            this.ctrlTransactionLines.ThreeDCheckBoxes = true;
            this.ctrlTransactionLines.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ctrlTransactionLines_MouseClick);
            // 
            // ctrlOK
            // 
            this.ctrlOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlOK.Location = new System.Drawing.Point(453, 529);
            this.ctrlOK.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(87, 31);
            this.ctrlOK.TabIndex = 11;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCancel.Location = new System.Drawing.Point(554, 529);
            this.ctrlCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(87, 31);
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
            this.ctrlAddNewTransactionLabel.Size = new System.Drawing.Size(218, 24);
            this.ctrlAddNewTransactionLabel.TabIndex = 13;
            this.ctrlAddNewTransactionLabel.Text = "Add new transaction...";
            // 
            // ctrlCustomers
            // 
            this.ctrlCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCustomers.FullRowSelect = true;
            this.ctrlCustomers.HideSelection = false;
            this.ctrlCustomers.Location = new System.Drawing.Point(214, 109);
            this.ctrlCustomers.Name = "ctrlCustomers";
            this.ctrlCustomers.Size = new System.Drawing.Size(347, 112);
            this.ctrlCustomers.TabIndex = 13;
            this.ctrlCustomers.UseCompatibleStateImageBehavior = false;
            // 
            // ctrlCars
            // 
            this.ctrlCars.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCars.FullRowSelect = true;
            this.ctrlCars.HideSelection = false;
            this.ctrlCars.Location = new System.Drawing.Point(214, 238);
            this.ctrlCars.Name = "ctrlCars";
            this.ctrlCars.Size = new System.Drawing.Size(348, 109);
            this.ctrlCars.TabIndex = 14;
            this.ctrlCars.UseCompatibleStateImageBehavior = false;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 675);
            this.Controls.Add(this.ctrlAddNewTransactionLabel);
            this.Controls.Add(this.ctrlCars);
            this.Controls.Add(this.ctrlCustomers);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOK);
            this.Controls.Add(this.ctrlTransactionLines);
            this.Controls.Add(this.ctrlDate);
            this.Controls.Add(this.ctrlCarIDLabel);
            this.Controls.Add(this.ctrlTransactionLinesLabel);
            this.Controls.Add(this.ctrlCustomerIDLabel);
            this.Controls.Add(this.ctrlDateLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.CheckedListBox ctrlTransactionLines;
        private System.Windows.Forms.Button ctrlOK;
        private System.Windows.Forms.Button ctrlCancel;

        private System.Windows.Forms.Label ctrlAddNewTransactionLabel;

        private System.Windows.Forms.ListView ctrlCustomers;
        private System.Windows.Forms.ListView ctrlCars;

    }
}