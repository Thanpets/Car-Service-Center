
namespace CarServiceCenter.WUI {
    partial class MonthlyLedgerForm {
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlMontlyList = new DevExpress.XtraEditors.ListBoxControl();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMontlyList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Russo One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(230, 35);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Monthly Ledger";
            // 
            // ctrlMontlyList
            // 
            this.ctrlMontlyList.Location = new System.Drawing.Point(25, 95);
            this.ctrlMontlyList.Name = "ctrlMontlyList";
            this.ctrlMontlyList.Size = new System.Drawing.Size(456, 168);
            this.ctrlMontlyList.TabIndex = 6;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(341, 40);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
            this.BtnRefresh.TabIndex = 7;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // MonthlyLedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.ctrlMontlyList);
            this.Controls.Add(this.labelControl1);
            this.Name = "MonthlyLedgerForm";
            this.Text = "MonthlyLedgerForm";
            this.Load += new System.EventHandler(this.MonthlyLedgerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlMontlyList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ListBoxControl ctrlMontlyList;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
    }
}