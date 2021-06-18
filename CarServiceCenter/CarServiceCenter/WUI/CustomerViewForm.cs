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
        public List<string> CustomersList = new List<string>();
        private JsonHandler MyJsonHandler { get; set; }

        public CustomerViewForm() {
            InitializeComponent();
            MyJsonHandler = new JsonHandler();
        }

        private void ctrlDisplayCustomers_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void CustomerViewForm_Load(object sender, EventArgs e) {

            ctrlDisplayCustomers.Items.Clear();
            LoadData();
        }


        private void LoadData() {
            foreach (string item in CustomersList) {
                ctrlDisplayCustomers.Items.Add(item);
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


            object listSelection = ctrlDisplayCustomers.SelectedItem;
            if (listSelection == null) {
                return Guid.Empty;
            }
            List<string> listParse = listSelection.ToString().Split(',').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(3));

            return id;

            //object listSelection = ctrlDisplayCustomers.SelectedItem;
            //List<string> listParse = listSelection.ToString().Split(',').ToList();
            //Guid id = Guid.Parse(listParse[0].Substring(3));

            //return id;

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
            CustomersList.Clear();

            foreach (Customer item in serviceCenter.Customers) {
                CustomersList.Add(string.Format("ID: {4}, Name: {0}, Surname: {1}, Phone: {2}, TIN: {3}",
                    item.Name, item.Surname, item.Phone, item.TIN, item.ID));
            }
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
