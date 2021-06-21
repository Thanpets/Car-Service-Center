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
        private JsonHandler MyJsonHandler { get; set; }

        public CustomerViewForm() {
            InitializeComponent();
            MyJsonHandler = new JsonHandler();
        }

        private void CustomerViewForm_Load(object sender, EventArgs e) {

            ctrlDisplayCustomers.Items.Clear();
            ctrlDisplayCustomers.View = View.Details;
            ctrlDisplayCustomers.Columns.Add("Name", 150);
            ctrlDisplayCustomers.Columns.Add("Last Name", 150);
            ctrlDisplayCustomers.Columns.Add("Phone", 200);
            ctrlDisplayCustomers.Columns.Add("TIN", 200);
            LoadData();
        }


        private void LoadData() {
            foreach (var item in serviceCenter.Customers) {
                string StringWithoutID = string.Format("{0},{1},{2},{3}", item.Name, item.Surname, item.Phone, item.TIN);
                string[] listParse = StringWithoutID.Split(',').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                ctrlDisplayCustomers.Items.Add(listViewItem);

            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            EditValue();
            RefreshItems();
        }

        private void EditValue() {
            Guid id = GetListID();


            if (id == Guid.Empty) {
                MessageBox.Show("You have to select an Item");
            }
            else {

                Customer customer = serviceCenter.Customers.Find(x => x.ID == id);

                CustomerForm editForm = new CustomerForm();
                editForm.MyCustomer = customer;
                editForm.ShowDialog();
            } 

        }

        private Guid GetListID() {

            if (ctrlDisplayCustomers.SelectedItems.Count == 0) {
                return Guid.Empty;
            }

            int index = ctrlDisplayCustomers.SelectedIndices[0];
            return serviceCenter.Customers[index].ID;

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            DeleteCustomer();
            RefreshItems();
        }

        private void DeleteCustomer() {
            Guid id = GetListID();

            if (id == Guid.Empty) {
                MessageBox.Show("You have to select an Item");
            }
            else {
                serviceCenter.Customers.RemoveAll(x => x.ID == id);
            }
            
        }

        private void RefreshItems() {

            ctrlDisplayCustomers.Items.Clear();
          
            LoadData();
            MyJsonHandler.SerializeToJson(serviceCenter);
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) {
            RefreshItems();
        }

        private void ctrlDisplayCustomers_MouseDoubleClick(object sender, MouseEventArgs e) {
            EditValue();
            RefreshItems();
        }
    }
}
