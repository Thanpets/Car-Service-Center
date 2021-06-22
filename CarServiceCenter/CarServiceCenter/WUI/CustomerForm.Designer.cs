
namespace CarServiceCenter.WUI {
    partial class CustomerForm {
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
            this.ctrlOk = new DevExpress.XtraEditors.SimpleButton();
            this.ctrlCancel = new DevExpress.XtraEditors.SimpleButton();
            this.LblName = new DevExpress.XtraEditors.LabelControl();
            this.ctrlName = new DevExpress.XtraEditors.TextEdit();
            this.ctrlPhone = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlSurname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.ctrlTIN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(93, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(151, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Add a Customer...";
            // 
            // ctrlOk
            // 
            this.ctrlOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlOk.Location = new System.Drawing.Point(522, 333);
            this.ctrlOk.Name = "ctrlOk";
            this.ctrlOk.Size = new System.Drawing.Size(87, 31);
            this.ctrlOk.TabIndex = 1;
            this.ctrlOk.Text = "OK";
            this.ctrlOk.Click += new System.EventHandler(this.ctrlOk_Click);
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCancel.Location = new System.Drawing.Point(626, 333);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(87, 31);
            this.ctrlCancel.TabIndex = 2;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // LblName
            // 
            this.LblName.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LblName.Appearance.Options.UseFont = true;
            this.LblName.Location = new System.Drawing.Point(82, 100);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(43, 16);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Name: ";
            // 
            // ctrlName
            // 
            this.ctrlName.EditValue = "";
            this.ctrlName.Location = new System.Drawing.Point(152, 97);
            this.ctrlName.Name = "ctrlName";
            this.ctrlName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlName.Properties.Appearance.Options.UseFont = true;
            this.ctrlName.Size = new System.Drawing.Size(211, 22);
            this.ctrlName.TabIndex = 4;
            // 
            // ctrlPhone
            // 
            this.ctrlPhone.EditValue = "";
            this.ctrlPhone.Location = new System.Drawing.Point(152, 183);
            this.ctrlPhone.Name = "ctrlPhone";
            this.ctrlPhone.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlPhone.Properties.Appearance.Options.UseFont = true;
            this.ctrlPhone.Size = new System.Drawing.Size(211, 22);
            this.ctrlPhone.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(83, 186);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 16);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Phone:";
            // 
            // ctrlSurname
            // 
            this.ctrlSurname.EditValue = "";
            this.ctrlSurname.Location = new System.Drawing.Point(152, 139);
            this.ctrlSurname.Name = "ctrlSurname";
            this.ctrlSurname.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlSurname.Properties.Appearance.Options.UseFont = true;
            this.ctrlSurname.Size = new System.Drawing.Size(211, 22);
            this.ctrlSurname.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(68, 142);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Surname:";
            // 
            // ctrlTIN
            // 
            this.ctrlTIN.EditValue = "";
            this.ctrlTIN.Location = new System.Drawing.Point(152, 226);
            this.ctrlTIN.Name = "ctrlTIN";
            this.ctrlTIN.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlTIN.Properties.Appearance.Options.UseFont = true;
            this.ctrlTIN.Size = new System.Drawing.Size(211, 22);
            this.ctrlTIN.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(100, 229);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(25, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "TIN:";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 380);
            this.Controls.Add(this.ctrlTIN);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.ctrlSurname);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.ctrlPhone);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.ctrlName);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOk);
            this.Controls.Add(this.labelControl1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlTIN.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton ctrlOk;
        private DevExpress.XtraEditors.SimpleButton ctrlCancel;
        private DevExpress.XtraEditors.LabelControl LblName;
        private DevExpress.XtraEditors.TextEdit ctrlName;
        private DevExpress.XtraEditors.TextEdit ctrlPhone;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit ctrlSurname;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit ctrlTIN;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}