
namespace CarServiceCenter.WUI {
    partial class CarForm {
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.crtlBrand = new DevExpress.XtraEditors.TextEdit();
            this.crtlModel = new DevExpress.XtraEditors.TextEdit();
            this.crtlCarRegistrationPlate = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.crtlBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlCarRegistrationPlate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(182, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(238, 36);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Add a new car...";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(127, 106);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 19);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Brand:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(125, 156);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Model:";
            // 
            // crtlBrand
            // 
            this.crtlBrand.Location = new System.Drawing.Point(182, 103);
            this.crtlBrand.Name = "crtlBrand";
            this.crtlBrand.Properties.Appearance.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtlBrand.Properties.Appearance.Options.UseFont = true;
            this.crtlBrand.Size = new System.Drawing.Size(171, 22);
            this.crtlBrand.TabIndex = 3;
            // 
            // crtlModel
            // 
            this.crtlModel.Location = new System.Drawing.Point(182, 153);
            this.crtlModel.Name = "crtlModel";
            this.crtlModel.Properties.Appearance.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtlModel.Properties.Appearance.Options.UseFont = true;
            this.crtlModel.Size = new System.Drawing.Size(171, 22);
            this.crtlModel.TabIndex = 4;
            // 
            // crtlCarRegistrationPlate
            // 
            this.crtlCarRegistrationPlate.Location = new System.Drawing.Point(182, 204);
            this.crtlCarRegistrationPlate.Name = "crtlCarRegistrationPlate";
            this.crtlCarRegistrationPlate.Properties.Appearance.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crtlCarRegistrationPlate.Properties.Appearance.Options.UseFont = true;
            this.crtlCarRegistrationPlate.Size = new System.Drawing.Size(171, 22);
            this.crtlCarRegistrationPlate.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(19, 207);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(157, 19);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "CarRegistrationPlate:";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Appearance.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Appearance.Options.UseFont = true;
            this.btnCreate.Location = new System.Drawing.Point(518, 320);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btnCreate.Size = new System.Drawing.Size(87, 31);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "OK";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(611, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(736, 380);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.crtlCarRegistrationPlate);
            this.Controls.Add(this.crtlModel);
            this.Controls.Add(this.crtlBrand);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car";
            this.Load += new System.EventHandler(this.CarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crtlBrand.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlCarRegistrationPlate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit crtlBrand;
        private DevExpress.XtraEditors.TextEdit crtlModel;
        private DevExpress.XtraEditors.TextEdit crtlCarRegistrationPlate;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}