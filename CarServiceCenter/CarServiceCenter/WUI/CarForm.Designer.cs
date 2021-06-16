
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreate = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.crtlBrand.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtlCarRegistrationPlate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(107, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Create a new car...";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(97, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Brand:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(97, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Model:";
            // 
            // crtlBrand
            // 
            this.crtlBrand.Location = new System.Drawing.Point(135, 50);
            this.crtlBrand.Name = "crtlBrand";
            this.crtlBrand.Size = new System.Drawing.Size(100, 20);
            this.crtlBrand.TabIndex = 3;
            // 
            // crtlModel
            // 
            this.crtlModel.Location = new System.Drawing.Point(135, 76);
            this.crtlModel.Name = "crtlModel";
            this.crtlModel.Size = new System.Drawing.Size(100, 20);
            this.crtlModel.TabIndex = 4;
            // 
            // crtlCarRegistrationPlate
            // 
            this.crtlCarRegistrationPlate.Location = new System.Drawing.Point(135, 108);
            this.crtlCarRegistrationPlate.Name = "crtlCarRegistrationPlate";
            this.crtlCarRegistrationPlate.Size = new System.Drawing.Size(100, 20);
            this.crtlCarRegistrationPlate.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(26, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(103, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "CarRegistrationPlate:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(528, 380);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(106, 48);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create ";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(654, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 48);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.crtlCarRegistrationPlate);
            this.Controls.Add(this.crtlModel);
            this.Controls.Add(this.crtlBrand);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "CarForm";
            this.Text = "Car";
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
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraEditors.SimpleButton btnCreate;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}