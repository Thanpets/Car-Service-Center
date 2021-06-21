
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
            this.ctrlCancel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlCancel.Location = new System.Drawing.Point(337, 199);
            this.ctrlCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlCancel.Name = "ctrlCancel";
            this.ctrlCancel.Size = new System.Drawing.Size(76, 31);
            this.ctrlCancel.TabIndex = 16;
            this.ctrlCancel.Text = "Cancel";
            this.ctrlCancel.UseVisualStyleBackColor = true;
            this.ctrlCancel.Click += new System.EventHandler(this.ctrlCancel_Click);
            // 
            // ctrlOK
            // 
            this.ctrlOK.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlOK.Location = new System.Drawing.Point(257, 199);
            this.ctrlOK.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlOK.Name = "ctrlOK";
            this.ctrlOK.Size = new System.Drawing.Size(76, 31);
            this.ctrlOK.TabIndex = 15;
            this.ctrlOK.Text = "OK";
            this.ctrlOK.UseVisualStyleBackColor = true;
            this.ctrlOK.Click += new System.EventHandler(this.ctrlOK_Click);
            // 
            // ctrlHours
            // 
            this.ctrlHours.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlHours.Location = new System.Drawing.Point(108, 117);
            this.ctrlHours.Margin = new System.Windows.Forms.Padding(2);
            this.ctrlHours.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrlHours.Name = "ctrlHours";
            this.ctrlHours.Size = new System.Drawing.Size(305, 26);
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
            this.ctrlHoursLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlHoursLabel.Location = new System.Drawing.Point(52, 119);
            this.ctrlHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ctrlHoursLabel.Name = "ctrlHoursLabel";
            this.ctrlHoursLabel.Size = new System.Drawing.Size(52, 19);
            this.ctrlHoursLabel.TabIndex = 13;
            this.ctrlHoursLabel.Text = "Hours";
            // 
            // TransactionLinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(525, 309);
            this.Controls.Add(this.ctrlCancel);
            this.Controls.Add(this.ctrlOK);
            this.Controls.Add(this.ctrlHours);
            this.Controls.Add(this.ctrlHoursLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TransactionLinesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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