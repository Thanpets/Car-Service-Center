
namespace CarServiceCenter.WUI {
    partial class EngineerForm {
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
            this.ctrlEngineerName = new System.Windows.Forms.Label();
            this.ctrlEngineerSurname = new System.Windows.Forms.Label();
            this.ctrlEngineerSalary = new System.Windows.Forms.Label();
            this.ctrlEngineerLabel = new System.Windows.Forms.Label();
            this.ctrlNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ctrlSurnameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctrlSalary = new System.Windows.Forms.NumericUpDown();
            this.ctrlDateLabel = new System.Windows.Forms.Label();
            this.ctrlEngineerDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurnameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEngineerDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEngineerDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlEngineerName
            // 
            this.ctrlEngineerName.AutoSize = true;
            this.ctrlEngineerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlEngineerName.Location = new System.Drawing.Point(93, 91);
            this.ctrlEngineerName.Name = "ctrlEngineerName";
            this.ctrlEngineerName.Size = new System.Drawing.Size(51, 16);
            this.ctrlEngineerName.TabIndex = 0;
            this.ctrlEngineerName.Text = "Name: ";
            // 
            // ctrlEngineerSurname
            // 
            this.ctrlEngineerSurname.AutoSize = true;
            this.ctrlEngineerSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlEngineerSurname.Location = new System.Drawing.Point(78, 137);
            this.ctrlEngineerSurname.Name = "ctrlEngineerSurname";
            this.ctrlEngineerSurname.Size = new System.Drawing.Size(65, 16);
            this.ctrlEngineerSurname.TabIndex = 2;
            this.ctrlEngineerSurname.Text = "Surname:";
            // 
            // ctrlEngineerSalary
            // 
            this.ctrlEngineerSalary.AutoSize = true;
            this.ctrlEngineerSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlEngineerSalary.Location = new System.Drawing.Point(93, 179);
            this.ctrlEngineerSalary.Name = "ctrlEngineerSalary";
            this.ctrlEngineerSalary.Size = new System.Drawing.Size(50, 16);
            this.ctrlEngineerSalary.TabIndex = 3;
            this.ctrlEngineerSalary.Text = "Salary:";
            // 
            // ctrlEngineerLabel
            // 
            this.ctrlEngineerLabel.AutoSize = true;
            this.ctrlEngineerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlEngineerLabel.Location = new System.Drawing.Point(98, 26);
            this.ctrlEngineerLabel.Name = "ctrlEngineerLabel";
            this.ctrlEngineerLabel.Size = new System.Drawing.Size(164, 24);
            this.ctrlEngineerLabel.TabIndex = 4;
            this.ctrlEngineerLabel.Text = "Add an Engineer..";
            // 
            // ctrlNameTextEdit
            // 
            this.ctrlNameTextEdit.EditValue = "";
            this.ctrlNameTextEdit.Location = new System.Drawing.Point(162, 88);
            this.ctrlNameTextEdit.Name = "ctrlNameTextEdit";
            this.ctrlNameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlNameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ctrlNameTextEdit.Size = new System.Drawing.Size(178, 22);
            this.ctrlNameTextEdit.TabIndex = 5;
            // 
            // ctrlSurnameTextEdit
            // 
            this.ctrlSurnameTextEdit.EditValue = "";
            this.ctrlSurnameTextEdit.Location = new System.Drawing.Point(162, 134);
            this.ctrlSurnameTextEdit.Name = "ctrlSurnameTextEdit";
            this.ctrlSurnameTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlSurnameTextEdit.Properties.Appearance.Options.UseFont = true;
            this.ctrlSurnameTextEdit.Size = new System.Drawing.Size(178, 22);
            this.ctrlSurnameTextEdit.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(516, 322);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 31);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(609, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctrlSalary
            // 
            this.ctrlSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlSalary.Location = new System.Drawing.Point(162, 179);
            this.ctrlSalary.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ctrlSalary.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ctrlSalary.Name = "ctrlSalary";
            this.ctrlSalary.Size = new System.Drawing.Size(178, 22);
            this.ctrlSalary.TabIndex = 10;
            this.ctrlSalary.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // ctrlDateLabel
            // 
            this.ctrlDateLabel.AutoSize = true;
            this.ctrlDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlDateLabel.Location = new System.Drawing.Point(75, 228);
            this.ctrlDateLabel.Name = "ctrlDateLabel";
            this.ctrlDateLabel.Size = new System.Drawing.Size(68, 16);
            this.ctrlDateLabel.TabIndex = 11;
            this.ctrlDateLabel.Text = "Hire Date:";
            // 
            // ctrlEngineerDate
            // 
            this.ctrlEngineerDate.EditValue = null;
            this.ctrlEngineerDate.Location = new System.Drawing.Point(162, 225);
            this.ctrlEngineerDate.Name = "ctrlEngineerDate";
            this.ctrlEngineerDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlEngineerDate.Properties.Appearance.Options.UseFont = true;
            this.ctrlEngineerDate.Properties.BeepOnError = false;
            this.ctrlEngineerDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlEngineerDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ctrlEngineerDate.Properties.MaskSettings.Set("mask", "d");
            this.ctrlEngineerDate.Properties.UseMaskAsDisplayFormat = true;
            this.ctrlEngineerDate.Size = new System.Drawing.Size(178, 22);
            this.ctrlEngineerDate.TabIndex = 12;
            // 
            // EngineerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 380);
            this.Controls.Add(this.ctrlEngineerDate);
            this.Controls.Add(this.ctrlDateLabel);
            this.Controls.Add(this.ctrlSalary);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctrlSurnameTextEdit);
            this.Controls.Add(this.ctrlNameTextEdit);
            this.Controls.Add(this.ctrlEngineerLabel);
            this.Controls.Add(this.ctrlEngineerSalary);
            this.Controls.Add(this.ctrlEngineerSurname);
            this.Controls.Add(this.ctrlEngineerName);
            this.Name = "EngineerForm";
            this.Text = "EngineerForm";
            this.Load += new System.EventHandler(this.EngineerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ctrlNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSurnameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEngineerDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlEngineerDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctrlEngineerName;
        private System.Windows.Forms.Label ctrlEngineerSurname;
        private System.Windows.Forms.Label ctrlEngineerSalary;
        private System.Windows.Forms.Label ctrlEngineerLabel;
        private DevExpress.XtraEditors.TextEdit ctrlNameTextEdit;
        private DevExpress.XtraEditors.TextEdit ctrlSurnameTextEdit;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown ctrlSalary;
        private System.Windows.Forms.Label ctrlDateLabel;
        private DevExpress.XtraEditors.DateEdit ctrlEngineerDate;
    }
}