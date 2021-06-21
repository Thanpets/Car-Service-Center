
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
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlMontlyList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(25, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(200, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Monthly Ledger";
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
            // ctrlMontlyList
            // 
            this.ctrlMontlyList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlMontlyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlMontlyList.FullRowSelect = true;
            this.ctrlMontlyList.HideSelection = false;
            this.ctrlMontlyList.Location = new System.Drawing.Point(35, 98);
            this.ctrlMontlyList.Name = "ctrlMontlyList";
            this.ctrlMontlyList.Size = new System.Drawing.Size(657, 336);
            this.ctrlMontlyList.TabIndex = 8;
            this.ctrlMontlyList.UseCompatibleStateImageBehavior = false;
            // 
            // MonthlyLedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 477);
            this.Controls.Add(this.ctrlMontlyList);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.labelControl1);
            this.Name = "MonthlyLedgerForm";
            this.Text = "MonthlyLedgerForm";
            this.Load += new System.EventHandler(this.MonthlyLedgerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private System.Windows.Forms.ListView ctrlMontlyList;
    }
}