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
    public partial class CustomerViewForm : Form {

        public List<string> ViewCustomerData = new List<string>();

        public CustomerViewForm() {
            InitializeComponent();
        }

        private void ctrlDisplayCustomers_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void CustomerViewForm_Load(object sender, EventArgs e) {

            ctrlDisplayCustomers.Items.Clear();

            foreach (string item in ViewCustomerData) {
                ctrlDisplayCustomers.Items.Add(item);
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {

        }
    }
}
