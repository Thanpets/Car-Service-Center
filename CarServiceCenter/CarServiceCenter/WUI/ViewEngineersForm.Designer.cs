
namespace CarServiceCenter.WUI {
    partial class ViewEngineersForm {
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
            this.ctrlEditEngineer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteEngineer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnResfreshEngineers = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlEngineersListView = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlEditEngineer,
            this.btnDeleteEngineer,
            this.btnResfreshEngineers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctrlEditEngineer
            // 
            this.ctrlEditEngineer.Name = "ctrlEditEngineer";
            this.ctrlEditEngineer.Size = new System.Drawing.Size(39, 20);
            this.ctrlEditEngineer.Text = "Edit";
            this.ctrlEditEngineer.Click += new System.EventHandler(this.ctrlEditEngineer_Click);
            // 
            // btnDeleteEngineer
            // 
            this.btnDeleteEngineer.Name = "btnDeleteEngineer";
            this.btnDeleteEngineer.Size = new System.Drawing.Size(52, 20);
            this.btnDeleteEngineer.Text = "Delete";
            this.btnDeleteEngineer.Click += new System.EventHandler(this.btnDeleteEngineer_Click);
            // 
            // btnResfreshEngineers
            // 
            this.btnResfreshEngineers.Name = "btnResfreshEngineers";
            this.btnResfreshEngineers.Size = new System.Drawing.Size(58, 20);
            this.btnResfreshEngineers.Text = "Refresh";
            this.btnResfreshEngineers.Click += new System.EventHandler(this.btnResfreshEngineers_Click);
            // 
            // ctrlEngineersListView
            // 
            this.ctrlEngineersListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlEngineersListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlEngineersListView.FullRowSelect = true;
            this.ctrlEngineersListView.HideSelection = false;
            this.ctrlEngineersListView.Location = new System.Drawing.Point(0, 27);
            this.ctrlEngineersListView.MultiSelect = false;
            this.ctrlEngineersListView.Name = "ctrlEngineersListView";
            this.ctrlEngineersListView.Size = new System.Drawing.Size(711, 408);
            this.ctrlEngineersListView.TabIndex = 3;
            this.ctrlEngineersListView.UseCompatibleStateImageBehavior = false;
            this.ctrlEngineersListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ctrlEngineersListView_MouseDoubleClick);
            // 
            // ViewEngineersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 435);
            this.Controls.Add(this.ctrlEngineersListView);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ViewEngineersForm";
            this.Text = "ViewEngineersForm";
            this.Load += new System.EventHandler(this.ViewEngineersForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctrlEditEngineer;
        private System.Windows.Forms.ToolStripMenuItem btnDeleteEngineer;
        private System.Windows.Forms.ToolStripMenuItem btnResfreshEngineers;
        private System.Windows.Forms.ListView ctrlEngineersListView;
    }
}