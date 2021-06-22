
namespace CarServiceCenter.WUI {
    partial class TransactionLinesForm {
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
            this.ctrlCancel = new System.Windows.Forms.Button();
            this.ctrlOK = new System.Windows.Forms.Button();
            this.ctrlHours = new System.Windows.Forms.NumericUpDown();
            this.ctrlHoursLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrlCancel
            // 
            this.ctrlCancel.Location = new System.Drawing.Point(466, 176);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(101, 38);
            this.ctrlCancel.TabIndex = 16;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.UseVisualStyleBackColor = true;
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // ctrlOK
            // 
            this.ctrlOK.Location = new System.Drawing.Point(340, 176);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(101, 38);
            this.ctrlOK.TabIndex = 15;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // ctrlHours
            // 
            this.ctrlHours.Location = new System.Drawing.Point(161, 77);
            this.ctrlHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlHours.Name = "ctrlHours";
            this.ctrlHours.Size = new System.Drawing.Size(406, 22);
            this.ctrlHours.TabIndex = 14;
            this.ctrlHours.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ctrlHoursLabel
            // 
            this.ctrlHoursLabel.AutoSize = true;
            this.ctrlHoursLabel.Location = new System.Drawing.Point(53, 79);
            this.ctrlHoursLabel.Name = "ctrlHoursLabel";
            this.ctrlHoursLabel.Size = new System.Drawing.Size(46, 17);
            this.ctrlHoursLabel.TabIndex = 13;
            this.ctrlHoursLabel.Text = "Hours";
            // 
            // TransactionLinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 277);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOK);
            this.Controls.Add(this.ctrlHours);
            this.Controls.Add(this.ctrlHoursLabel);
            this.Name = "TransactionLinesForm";
            this.Text = "TransactionLinesForm";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctrlCancel;
        private System.Windows.Forms.Button ctrlOK;
        private System.Windows.Forms.NumericUpDown ctrlHours;
        private System.Windows.Forms.Label ctrlHoursLabel;
    }
}