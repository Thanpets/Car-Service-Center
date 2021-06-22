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
    public partial class ViewTransactionForm : Form {

        public ServiceCenter NewServiceCenter { get; set; }

        private JsonHandler MyJsonHandler = null;

        public ViewTransactionForm() {
            InitializeComponent();
            MyJsonHandler = new JsonHandler();
        }

        private void ViewTransactionForm_Load(object sender, EventArgs e) {

            ctrlDisplayTransactions.Items.Clear();

            ctrlDisplayTransactions.View = View.Details;
            ctrlDisplayTransactions.Columns.Add("Date", 100);
            ctrlDisplayTransactions.Columns.Add("Customer Name", 200);
            ctrlDisplayTransactions.Columns.Add("Car Model", 200);
            ctrlDisplayTransactions.Columns.Add("Total Price", 80);
            LoadData();
            RefreshTransactionsList();
        }

        private void LoadData() {
            foreach (var item in NewServiceCenter.Transactions) {
                Customer customer = NewServiceCenter.Customers.Find(x => x.ID == item.CustomerID);
                Car car = NewServiceCenter.Cars.Find(x => x.ID == item.CarID);
                string date = item.Date.Substring(0, item.Date.IndexOf(" "));
                string StringWithoutID = string.Format("{0},{1},{2},{3}", date , customer.Name + " " + customer.Surname, car.Brand + " " + car.Model, item.TotalPrice);
                string[] listParse = StringWithoutID.Split(',').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                ctrlDisplayTransactions.Items.Add(listViewItem);

            }
        }

        private Guid GetListID() {

            if (ctrlDisplayTransactions.SelectedItems.Count == 0) {
                return Guid.Empty;
            }

            int index = ctrlDisplayTransactions.SelectedIndices[0];
            return NewServiceCenter.Transactions[index].ID;

        }

        private void DeleteSelectedRecord() {

            Guid id = GetListID();

            if (id != Guid.Empty) {

                NewServiceCenter.Transactions.RemoveAll(x => x.ID == id);
            }
            else {

                MessageBox.Show("Please specify an entry.");
            }
        }

        private void RefreshTransactionsList() {

            ctrlDisplayTransactions.Items.Clear();

            LoadData();
            MyJsonHandler.SerializeToJson(NewServiceCenter);

            //ctrlDisplayTransactions.Items.Clear();

            //MyJsonHandler = new JsonHandler();

            //string lines = string.Empty;

            //foreach (Transaction trans in NewServiceCenter.Transactions) {

            //    foreach (var item in trans.TransactionLines) {


            //        lines += string.Format("[ {0} ]", NewServiceCenter.ServiceTasks.FindLast(x => x.ID == item.ServiceTaskID).Description);

            //    }

            //    ctrlDisplayTransactions.Items.Add(string.Format("ID={0}\tDate={1}\tCustomer TIN={2}\tCar Registration Plate={3}\tTotal Price={4}\tTransaction Lines={5}",
            //        trans.ID, trans.Date, NewServiceCenter.Customers.FindLast(x => x.ID == trans.CustomerID).TIN,
            //        NewServiceCenter.Cars.FindLast(x => x.ID == trans.CarID).CarRegistrationPlate, trans.TotalPrice, lines));

            //    lines = string.Empty;

            //}

            //MyJsonHandler.SerializeToJson(NewServiceCenter);

        }

        private void ctrlDeleteTransaction_Click(object sender, EventArgs e) {

            DeleteSelectedRecord();

            RefreshTransactionsList();
        }

        private void ctrlRefreshTransaction_Click(object sender, EventArgs e) {

            RefreshTransactionsList();
        }

        
    }
}
