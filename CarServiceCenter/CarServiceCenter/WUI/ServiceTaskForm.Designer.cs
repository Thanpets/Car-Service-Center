
namespace CarServiceCenter.WUI {
    partial class ServiceTaskForm {
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
            this.ctrlCodeLabel = new System.Windows.Forms.Label();
            this.ctrlDescriptionLabel = new System.Windows.Forms.Label();
            this.ctrlPricePerHourLabel = new System.Windows.Forms.Label();
            this.ctrlCode = new System.Windows.Forms.TextBox();
            this.ctrlDescription = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ctrlPricePerHour = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPricePerHour)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCodeLabel
            // 
            this.ctrlCodeLabel.AutoSize = true;
            this.ctrlCodeLabel.Location = new System.Drawing.Point(62, 83);
            this.ctrlCodeLabel.Name = "ctrlCodeLabel";
            this.ctrlCodeLabel.Size = new System.Drawing.Size(41, 17);
            this.ctrlCodeLabel.TabIndex = 0;
            this.ctrlCodeLabel.Text = "Code";
            // 
            // ctrlDescriptionLabel
            // 
            this.ctrlDescriptionLabel.AutoSize = true;
            this.ctrlDescriptionLabel.Location = new System.Drawing.Point(62, 148);
            this.ctrlDescriptionLabel.Name = "ctrlDescriptionLabel";
            this.ctrlDescriptionLabel.Size = new System.Drawing.Size(79, 17);
            this.ctrlDescriptionLabel.TabIndex = 1;
            this.ctrlDescriptionLabel.Text = "Description";
            // 
            // ctrlPricePerHourLabel
            // 
            this.ctrlPricePerHourLabel.AutoSize = true;
            this.ctrlPricePerHourLabel.Location = new System.Drawing.Point(62, 217);
            this.ctrlPricePerHourLabel.Name = "ctrlPricePerHourLabel";
            this.ctrlPricePerHourLabel.Size = new System.Drawing.Size(98, 17);
            this.ctrlPricePerHourLabel.TabIndex = 2;
            this.ctrlPricePerHourLabel.Text = "Price per hour";
            // 
            // ctrlCode
            // 
            this.ctrlCode.Location = new System.Drawing.Point(180, 80);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(442, 22);
            this.ctrlCode.TabIndex = 3;
            // 
            // ctrlDescription
            // 
            this.ctrlDescription.Location = new System.Drawing.Point(180, 145);
            this.ctrlDescription.Name = "ctrlDescription";
            this.ctrlDescription.Size = new System.Drawing.Size(442, 22);
            this.ctrlDescription.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(445, 344);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(547, 344);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctrlPricePerHour
            // 
            this.ctrlPricePerHour.DecimalPlaces = 2;
            this.ctrlPricePerHour.Location = new System.Drawing.Point(180, 215);
            this.ctrlPricePerHour.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ctrlPricePerHour.Name = "ctrlPricePerHour";
            this.ctrlPricePerHour.Size = new System.Drawing.Size(442, 22);
            this.ctrlPricePerHour.TabIndex = 8;
            // 
            // ServiceTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlPricePerHour);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctrlDescription);
            this.Controls.Add(this.ctrlCode);
            this.Controls.Add(this.ctrlPricePerHourLabel);
            this.Controls.Add(this.ctrlDescriptionLabel);
            this.Controls.Add(this.ctrlCodeLabel);
            this.Name = "ServiceTaskForm";
            this.Text = "ServiceTaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPricePerHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ctrlCodeLabel;
        private System.Windows.Forms.Label ctrlDescriptionLabel;
        private System.Windows.Forms.Label ctrlPricePerHourLabel;
        private System.Windows.Forms.TextBox ctrlCode;
        private System.Windows.Forms.TextBox ctrlDescription;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown ctrlPricePerHour;
    }
}