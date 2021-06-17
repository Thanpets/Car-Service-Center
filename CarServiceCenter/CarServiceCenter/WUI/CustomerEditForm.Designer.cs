
namespace CarServiceCenter.WUI {
    partial class CustomerEditForm {
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
            this.Lbltitle = new DevExpress.XtraEditors.LabelControl();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTIN = new DevExpress.XtraEditors.TextEdit();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOk = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbltitle
            // 
            this.Lbltitle.Appearance.Font = new System.Drawing.Font("Russo One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltitle.Appearance.Options.UseFont = true;
            this.Lbltitle.Location = new System.Drawing.Point(39, 27);
            this.Lbltitle.Name = "Lbltitle";
            this.Lbltitle.Size = new System.Drawing.Size(204, 25);
            this.Lbltitle.TabIndex = 0;
            this.Lbltitle.Text = "Edit Customer Data";
            // 
            // ctrlName
            // 
            this.ctrlName.Location = new System.Drawing.Point(108, 111);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Size = new System.Drawing.Size(188, 20);
            this.ctrlName.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(39, 114);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(31, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(39, 140);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Surname:";
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.Location = new System.Drawing.Point(108, 137);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Size = new System.Drawing.Size(188, 20);
            this.ctrlSurname.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(39, 166);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Phone:";
            // 
            // ctrlPhone
            // 
            this.ctrlPhone.Location = new System.Drawing.Point(108, 163);
            this.ctrlPhone.Name = "ctrlPhone";
            this.ctrlPhone.Size = new System.Drawing.Size(188, 20);
            this.ctrlPhone.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(39, 192);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(21, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "TIN:";
            // 
            // ctrlTIN
            // 
            this.ctrlTIN.Location = new System.Drawing.Point(108, 189);
            this.ctrlTIN.Name = "ctrlTIN";
            this.ctrlTIN.Size = new System.Drawing.Size(188, 20);
            this.ctrlTIN.TabIndex = 7;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(448, 358);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 9;
            this.BtnCancel.Text = "Cancel";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(367, 358);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 10;
            this.BtnOk.Text = "OK";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 393);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctrlTIN);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ctrlPhone);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.Lbltitle);
            this.Name = "CustomerEditForm";
            this.Text = "CustomerEditForm";
            this.Load += new System.EventHandler(this.CustomerEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl Lbltitle;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit ctrlPhone;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit ctrlTIN;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnOk;
    }
}