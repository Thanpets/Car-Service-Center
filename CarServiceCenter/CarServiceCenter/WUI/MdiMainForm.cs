using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceCenter.WUI {
    public partial class MdiMainForm : Form {
        public MdiMainForm() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Application.Exit();
        }

        private void ctrlAddEngineer_Click(object sender, EventArgs e) {
            AddEngineer();
        }

        private void AddEngineer() {
            Engineer engineer = new Engineer();

            EngineerForm engineerForm = new EngineerForm();
            engineerForm.MyEngineer = engineer;

            engineerForm.MdiParent = this;
            engineerForm.Show();

        }
    }
}
