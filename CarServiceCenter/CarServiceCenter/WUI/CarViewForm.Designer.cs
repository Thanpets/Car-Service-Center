
namespace CarServiceCenter.WUI {
    partial class CarViewForm {
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ctrlEditCar = new System.Windows.Forms.ToolStripMenuItem();
            this.crtlDeleteCar = new System.Windows.Forms.ToolStripMenuItem();
            this.crtlRefreshCar = new System.Windows.Forms.ToolStripMenuItem();
            this.crtlViewCarList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlEditCar,
            this.crtlDeleteCar,
            this.crtlRefreshCar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctrlEditCar
            // 
            this.ctrlEditCar.Name = "ctrlEditCar";
            this.ctrlEditCar.Size = new System.Drawing.Size(39, 20);
            this.ctrlEditCar.Text = "Edit";
            // 
            // crtlDeleteCar
            // 
            this.crtlDeleteCar.Name = "crtlDeleteCar";
            this.crtlDeleteCar.Size = new System.Drawing.Size(52, 20);
            this.crtlDeleteCar.Text = "Delete";
            // 
            // crtlRefreshCar
            // 
            this.crtlRefreshCar.Name = "crtlRefreshCar";
            this.crtlRefreshCar.Size = new System.Drawing.Size(58, 20);
            this.crtlRefreshCar.Text = "Refresh";
            // 
            // crtlViewCarList
            // 
            this.crtlViewCarList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtlViewCarList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.crtlViewCarList.FormattingEnabled = true;
            this.crtlViewCarList.ItemHeight = 18;
            this.crtlViewCarList.Location = new System.Drawing.Point(0, 24);
            this.crtlViewCarList.Margin = new System.Windows.Forms.Padding(2);
            this.crtlViewCarList.Name = "crtlViewCarList";
            this.crtlViewCarList.Size = new System.Drawing.Size(800, 426);
            this.crtlViewCarList.TabIndex = 4;
            // 
            // CarViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crtlViewCarList);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CarViewForm";
            this.Text = "CarViewForm";
            this.Load += new System.EventHandler(this.CarViewForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctrlEditCar;
        private System.Windows.Forms.ToolStripMenuItem crtlDeleteCar;
        private System.Windows.Forms.ToolStripMenuItem crtlRefreshCar;
        private System.Windows.Forms.ListBox crtlViewCarList;
    }
}