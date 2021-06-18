
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
            this.ctrlDisplayTransactions = new System.Windows.Forms.ListBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctrlDeleteTransaction
            // 
            this.ctrlDeleteTransaction.Name = "ctrlDeleteTransaction";
            this.ctrlDeleteTransaction.Size = new System.Drawing.Size(67, 24);
            this.ctrlDeleteTransaction.Text = "Delete";
            this.ctrlDeleteTransaction.Click += new System.EventHandler(this.ctrlDeleteTransaction_Click);
            // 
            // ctrlRefreshTransaction
            // 
            this.ctrlRefreshTransaction.Name = "ctrlRefreshTransaction";
            this.ctrlRefreshTransaction.Size = new System.Drawing.Size(72, 24);
            this.ctrlRefreshTransaction.Text = "Refresh";
            this.ctrlRefreshTransaction.Click += new System.EventHandler(this.ctrlRefreshTransaction_Click);
            // 
            // ctrlDisplayTransactions
            // 
            this.ctrlDisplayTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlDisplayTransactions.FormattingEnabled = true;
            this.ctrlDisplayTransactions.ItemHeight = 16;
            this.ctrlDisplayTransactions.Location = new System.Drawing.Point(0, 28);
            this.ctrlDisplayTransactions.Name = "ctrlDisplayTransactions";
            this.ctrlDisplayTransactions.Size = new System.Drawing.Size(800, 422);
            this.ctrlDisplayTransactions.TabIndex = 1;
            this.ctrlDisplayTransactions.MouseEnter += new System.EventHandler(this.ctrlDisplayTransactions_MouseEnter);
            // 
            // ViewTransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlDisplayTransactions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ViewTransactionForm";
            this.Text = "ViewTransactionForm";
            this.Load += new System.EventHandler(this.ViewTransactionForm_Load);
            this.MouseEnter += new System.EventHandler(this.ViewTransactionForm_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ViewTransactionForm_MouseLeave);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctrlDeleteTransaction;
        private System.Windows.Forms.ToolStripMenuItem ctrlRefreshTransaction;
        private System.Windows.Forms.ListBox ctrlDisplayTransactions;
    }
}