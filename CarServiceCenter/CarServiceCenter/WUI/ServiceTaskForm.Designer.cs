
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPricePerHour)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCodeLabel
            // 
            this.ctrlCodeLabel.AutoSize = true;
            this.ctrlCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCodeLabel.Location = new System.Drawing.Point(97, 95);
            this.ctrlCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlCodeLabel.Name = "ctrlCodeLabel";
            this.ctrlCodeLabel.Size = new System.Drawing.Size(44, 16);
            this.ctrlCodeLabel.TabIndex = 0;
            this.ctrlCodeLabel.Text = "Code:";
            // 
            // ctrlDescriptionLabel
            // 
            this.ctrlDescriptionLabel.AutoSize = true;
            this.ctrlDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlDescriptionLabel.Location = new System.Drawing.Point(62, 142);
            this.ctrlDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlDescriptionLabel.Name = "ctrlDescriptionLabel";
            this.ctrlDescriptionLabel.Size = new System.Drawing.Size(79, 16);
            this.ctrlDescriptionLabel.TabIndex = 1;
            this.ctrlDescriptionLabel.Text = "Description:";
            // 
            // ctrlPricePerHourLabel
            // 
            this.ctrlPricePerHourLabel.AutoSize = true;
            this.ctrlPricePerHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlPricePerHourLabel.Location = new System.Drawing.Point(47, 191);
            this.ctrlPricePerHourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlPricePerHourLabel.Name = "ctrlPricePerHourLabel";
            this.ctrlPricePerHourLabel.Size = new System.Drawing.Size(94, 16);
            this.ctrlPricePerHourLabel.TabIndex = 2;
            this.ctrlPricePerHourLabel.Text = "Price per hour:";
            // 
            // ctrlCode
            // 
            this.ctrlCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlCode.Location = new System.Drawing.Point(165, 92);
            this.ctrlCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(250, 22);
            this.ctrlCode.TabIndex = 0;
            // 
            // ctrlDescription
            // 
            this.ctrlDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlDescription.Location = new System.Drawing.Point(165, 139);
            this.ctrlDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlDescription.Name = "ctrlDescription";
            this.ctrlDescription.Size = new System.Drawing.Size(250, 22);
            this.ctrlDescription.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(510, 321);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(87, 31);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(610, 321);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 31);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ctrlPricePerHour
            // 
            this.ctrlPricePerHour.DecimalPlaces = 1;
            this.ctrlPricePerHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlPricePerHour.Location = new System.Drawing.Point(165, 189);
            this.ctrlPricePerHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ctrlPricePerHour.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.ctrlPricePerHour.Name = "ctrlPricePerHour";
            this.ctrlPricePerHour.Size = new System.Drawing.Size(250, 22);
            this.ctrlPricePerHour.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add new service task...";
            // 
            // ServiceTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrlPricePerHour);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ctrlDescription);
            this.Controls.Add(this.ctrlCode);
            this.Controls.Add(this.ctrlPricePerHourLabel);
            this.Controls.Add(this.ctrlDescriptionLabel);
            this.Controls.Add(this.ctrlCodeLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ServiceTaskForm";
            this.Text = "ServiceTaskForm";
            this.Load += new System.EventHandler(this.ServiceTaskForm_Load);
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
        private System.Windows.Forms.Label label1;
    }
}