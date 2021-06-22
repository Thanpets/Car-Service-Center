
namespace CarServiceCenter.WUI {
    partial class MdiMainForm {
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
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlAddCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctrlViewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.carsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crtlAddCar = new System.Windows.Forms.ToolStripMenuItem();
            this.crtlViewCars = new System.Windows.Forms.ToolStripMenuItem();
            this.engineersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlAddEngineer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.ctrlViewEngineer = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlAddServiceTask = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.ctrlViewServiceTask = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlAddTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.ctrlViewTransaction = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlyLedgerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlMonthlyLedgerView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.carsToolStripMenuItem,
            this.engineersToolStripMenuItem,
            this.serviceTaskToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.monthlyLedgerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlAddCustomer,
            this.toolStripMenuItem2,
            this.ctrlViewCustomer});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // ctrlAddCustomer
            // 
            this.ctrlAddCustomer.Name = "ctrlAddCustomer";
            this.ctrlAddCustomer.Size = new System.Drawing.Size(180, 22);
            this.ctrlAddCustomer.Text = "Add..";
            this.ctrlAddCustomer.Click += new System.EventHandler(this.ctrlAddCustomer_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // ctrlViewCustomer
            // 
            this.ctrlViewCustomer.Name = "ctrlViewCustomer";
            this.ctrlViewCustomer.Size = new System.Drawing.Size(180, 22);
            this.ctrlViewCustomer.Text = "View";
            this.ctrlViewCustomer.Click += new System.EventHandler(this.ctrlViewCustomer_Click);
            // 
            // carsToolStripMenuItem
            // 
            this.carsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crtlAddCar,
            this.crtlViewCars});
            this.carsToolStripMenuItem.Name = "carsToolStripMenuItem";
            this.carsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.carsToolStripMenuItem.Text = "Cars";
            // 
            // crtlAddCar
            // 
            this.crtlAddCar.Name = "crtlAddCar";
            this.crtlAddCar.Size = new System.Drawing.Size(180, 22);
            this.crtlAddCar.Text = "Add..";
            this.crtlAddCar.Click += new System.EventHandler(this.crtlAddCar_Click);
            // 
            // crtlViewCars
            // 
            this.crtlViewCars.Name = "crtlViewCars";
            this.crtlViewCars.Size = new System.Drawing.Size(180, 22);
            this.crtlViewCars.Text = "View";
            this.crtlViewCars.Click += new System.EventHandler(this.crtlViewCars_Click);
            // 
            // engineersToolStripMenuItem
            // 
            this.engineersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlAddEngineer,
            this.toolStripMenuItem3,
            this.ctrlViewEngineer});
            this.engineersToolStripMenuItem.Name = "engineersToolStripMenuItem";
            this.engineersToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.engineersToolStripMenuItem.Text = "Engineers";
            // 
            // ctrlAddEngineer
            // 
            this.ctrlAddEngineer.Name = "ctrlAddEngineer";
            this.ctrlAddEngineer.Size = new System.Drawing.Size(180, 22);
            this.ctrlAddEngineer.Text = "Add..";
            this.ctrlAddEngineer.Click += new System.EventHandler(this.ctrlAddEngineer_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // ctrlViewEngineer
            // 
            this.ctrlViewEngineer.Name = "ctrlViewEngineer";
            this.ctrlViewEngineer.Size = new System.Drawing.Size(180, 22);
            this.ctrlViewEngineer.Text = "View";
            this.ctrlViewEngineer.Click += new System.EventHandler(this.ctrlViewEngineer_Click);
            // 
            // serviceTaskToolStripMenuItem
            // 
            this.serviceTaskToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlAddServiceTask,
            this.toolStripMenuItem4,
            this.ctrlViewServiceTask});
            this.serviceTaskToolStripMenuItem.Name = "serviceTaskToolStripMenuItem";
            this.serviceTaskToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.serviceTaskToolStripMenuItem.Text = "Service Task";
            // 
            // ctrlAddServiceTask
            // 
            this.ctrlAddServiceTask.Name = "ctrlAddServiceTask";
            this.ctrlAddServiceTask.Size = new System.Drawing.Size(102, 22);
            this.ctrlAddServiceTask.Text = "Add..";
            this.ctrlAddServiceTask.Click += new System.EventHandler(this.ctrlAddServiceTask_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(99, 6);
            // 
            // ctrlViewServiceTask
            // 
            this.ctrlViewServiceTask.Name = "ctrlViewServiceTask";
            this.ctrlViewServiceTask.Size = new System.Drawing.Size(102, 22);
            this.ctrlViewServiceTask.Text = "View";
            this.ctrlViewServiceTask.Click += new System.EventHandler(this.ctrlViewServiceTask_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlAddTransaction,
            this.toolStripMenuItem5,
            this.ctrlViewTransaction});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // ctrlAddTransaction
            // 
            this.ctrlAddTransaction.Name = "ctrlAddTransaction";
            this.ctrlAddTransaction.Size = new System.Drawing.Size(126, 26);
            this.ctrlAddTransaction.Text = "Add..";
            this.ctrlAddTransaction.Click += new System.EventHandler(this.ctrlAddTransaction_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(99, 6);
            // 
            // ctrlViewTransaction
            // 
            this.ctrlViewTransaction.Name = "ctrlViewTransaction";
            this.ctrlViewTransaction.Size = new System.Drawing.Size(126, 26);
            this.ctrlViewTransaction.Text = "View";
            this.ctrlViewTransaction.Click += new System.EventHandler(this.ctrlViewTransaction_Click);
            // 
            // monthlyLedgerToolStripMenuItem
            // 
            this.monthlyLedgerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrlMonthlyLedgerView});
            this.monthlyLedgerToolStripMenuItem.Name = "monthlyLedgerToolStripMenuItem";
            this.monthlyLedgerToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.monthlyLedgerToolStripMenuItem.Text = "Monthly Ledger";
            // 
            // ctrlMonthlyLedgerView
            // 
            this.ctrlMonthlyLedgerView.Name = "ctrlMonthlyLedgerView";
            this.ctrlMonthlyLedgerView.Size = new System.Drawing.Size(99, 22);
            this.ctrlMonthlyLedgerView.Text = "View";
            this.ctrlMonthlyLedgerView.Click += new System.EventHandler(this.ctrlMonthlyLedgerView_Click);
            // 
            // MdiMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MdiMainForm";
            this.Text = "MdiMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MdiMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlAddCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ctrlViewCustomer;
        private System.Windows.Forms.ToolStripMenuItem carsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crtlAddCar;
        private System.Windows.Forms.ToolStripMenuItem crtlViewCars;
        private System.Windows.Forms.ToolStripMenuItem engineersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlAddEngineer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem ctrlViewEngineer;
        private System.Windows.Forms.ToolStripMenuItem serviceTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlAddServiceTask;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem ctrlViewServiceTask;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlAddTransaction;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem ctrlViewTransaction;
        private System.Windows.Forms.ToolStripMenuItem monthlyLedgerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrlMonthlyLedgerView;
    }
}