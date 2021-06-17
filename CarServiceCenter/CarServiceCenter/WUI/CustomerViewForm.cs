using CarServiceCenter.Impl;
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

        public ServiceCenter serviceCenter { get; set; }
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
            Guid id = GetListID();
            Object editObject = null;

            editObject = serviceCenter.Customers.Find(x => x.ID == id);

            CustomerEditForm editForm = new CustomerEditForm();
            editForm.EditObject = editObject;
            editForm.ShowDialog();

        }

        private Guid GetListID() {
            object listSelection = ctrlDisplayCustomers.SelectedItem;
            List<string> listParse = listSelection.ToString().Split(',').ToList();

           Guid id = Guid.Parse(listParse[0].Substring(3));
           return id;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            Guid id = GetListID();
            serviceCenter.Customers.RemoveAll(x => x.ID == id);

        }
    }
}
