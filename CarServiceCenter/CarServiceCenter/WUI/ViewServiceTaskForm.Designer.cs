
namespace CarServiceCenter.WUI {
    partial class ViewServiceTaskForm {
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
            this.ctrlEditServiceTask = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlDeleteServiceTask = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlRefreshServiceTask = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlDisplayServiceTasks = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlEditServiceTask,
            this.ctrlDeleteServiceTask,
            this.ctrlRefreshServiceTask});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(703, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ctrlEditServiceTask
            // 
            this.ctrlEditServiceTask.Name = "ctrlEditServiceTask";
            this.ctrlEditServiceTask.Size = new System.Drawing.Size(39, 20);
            this.ctrlEditServiceTask.Text = "Edit";
            this.ctrlEditServiceTask.Click += new System.EventHandler(this.ctrlEditServiceTask_Click);
            // 
            // ctrlDeleteServiceTask
            // 
            this.ctrlDeleteServiceTask.Name = "ctrlDeleteServiceTask";
            this.ctrlDeleteServiceTask.Size = new System.Drawing.Size(52, 20);
            this.ctrlDeleteServiceTask.Text = "Delete";
            this.ctrlDeleteServiceTask.Click += new System.EventHandler(this.ctrlDeleteServiceTask_Click);
            // 
            // ctrlRefreshServiceTask
            // 
            this.ctrlRefreshServiceTask.Name = "ctrlRefreshServiceTask";
            this.ctrlRefreshServiceTask.Size = new System.Drawing.Size(58, 20);
            this.ctrlRefreshServiceTask.Text = "Refresh";
            this.ctrlRefreshServiceTask.Click += new System.EventHandler(this.ctrlRefreshServiceTask_Click);
            // 
            // ctrlDisplayServiceTasks
            // 
            this.ctrlDisplayServiceTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlDisplayServiceTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ctrlDisplayServiceTasks.FullRowSelect = true;
            this.ctrlDisplayServiceTasks.HideSelection = false;
            this.ctrlDisplayServiceTasks.Location = new System.Drawing.Point(0, 27);
            this.ctrlDisplayServiceTasks.Name = "ctrlDisplayServiceTasks";
            this.ctrlDisplayServiceTasks.Size = new System.Drawing.Size(703, 453);
            this.ctrlDisplayServiceTasks.TabIndex = 2;
            this.ctrlDisplayServiceTasks.UseCompatibleStateImageBehavior = false;
            this.ctrlDisplayServiceTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ctrlDisplayServiceTasks_MouseDoubleClick);
            // 
            // ViewServiceTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 480);
            this.Controls.Add(this.ctrlDisplayServiceTasks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewServiceTaskForm";
            this.Text = "ViewServiceTaskForm";
            this.Load += new System.EventHandler(this.ViewServiceTaskForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctrlEditServiceTask;
        private System.Windows.Forms.ToolStripMenuItem ctrlDeleteServiceTask;
        private System.Windows.Forms.ToolStripMenuItem ctrlRefreshServiceTask;
        private System.Windows.Forms.ListView ctrlDisplayServiceTasks;
    }
}