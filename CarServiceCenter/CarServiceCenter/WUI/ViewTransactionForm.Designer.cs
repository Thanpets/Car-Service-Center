
namespace CarServiceCenter.WUI {
    partial class ViewTransactionForm {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ctrlDeleteTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlRefreshTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlDisplayTransactions = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlDeleteTransaction,
            this.ctrlRefreshTransaction});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctrlDeleteTransaction
            // 
            this.ctrlDeleteTransaction.Name = "ctrlDeleteTransaction";
            this.ctrlDeleteTransaction.Size = new System.Drawing.Size(52, 20);
            this.ctrlDeleteTransaction.Text = "Delete";
            this.ctrlDeleteTransaction.Click += new System.EventHandler(this.ctrlDeleteTransaction_Click);
            // 
            // ctrlRefreshTransaction
            // 
            this.ctrlRefreshTransaction.Name = "ctrlRefreshTransaction";
            this.ctrlRefreshTransaction.Size = new System.Drawing.Size(58, 20);
            this.ctrlRefreshTransaction.Text = "Refresh";
            this.ctrlRefreshTransaction.Click += new System.EventHandler(this.ctrlRefreshTransaction_Click);
            // 
            // ctrlDisplayTransactions
            // 
            this.ctrlDisplayTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlDisplayTransactions.FullRowSelect = true;
            this.ctrlDisplayTransactions.HideSelection = false;
            this.ctrlDisplayTransactions.Location = new System.Drawing.Point(0, 27);
            this.ctrlDisplayTransactions.Name = "ctrlDisplayTransactions";
            this.ctrlDisplayTransactions.Size = new System.Drawing.Size(600, 341);
            this.ctrlDisplayTransactions.TabIndex = 1;
            this.ctrlDisplayTransactions.UseCompatibleStateImageBehavior = false;
            // 
            // ViewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.ctrlDisplayTransactions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ViewTransactionForm";
            this.Text = "ViewTransactionForm";
            this.Load += new System.EventHandler(this.ViewTransactionForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctrlDeleteTransaction;
        private System.Windows.Forms.ToolStripMenuItem ctrlRefreshTransaction;
        private System.Windows.Forms.ListView ctrlDisplayTransactions;
    }
}