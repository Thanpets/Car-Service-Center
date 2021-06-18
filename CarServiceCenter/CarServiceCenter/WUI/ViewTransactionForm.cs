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

        //private List<string> transactions = null;

        private JsonHandler MyJsonHandler = null;



        public ViewTransactionForm() {
            InitializeComponent();
        }


        //private void RefreshView() {

        //    ctrlDisplayTransactions.Items.Clear();

        //    foreach (var item in NewServiceCenter.Transactions) {

        //        ctrlDisplayTransactions.Items.Add(item.ToString());

        //    }
        //}

        private Guid GetListID() {

            object listSelection = ctrlDisplayTransactions.SelectedItem;

            if (listSelection == null) {

                return Guid.Empty;

            }


            List<string> listParse = listSelection.ToString().Split('\t').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(3));

            return id;
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



        //private List<string> RefreshTransactionsList() {
        private void RefreshTransactionsList() {

            ctrlDisplayTransactions.Items.Clear();

            MyJsonHandler = new JsonHandler();

            //transactions = new List<string>();

            //transactions.Clear();


            string lines = string.Empty;
            //foreach (var item in NewServiceCenter.Transactions) {

            //}


            foreach (Transaction trans in NewServiceCenter.Transactions) {

                foreach (var item in trans.TransactionLines) {


                    lines += string.Format("[ {0} ]", NewServiceCenter.ServiceTasks.FindLast(x => x.ID == item.ServiceTaskID).Description);

                }

                ctrlDisplayTransactions.Items.Add(string.Format("ID={0}\tDate={1}\tCustomer TIN={2}\tCar Registration Plate={3}\tTotal Price={4}\tTransaction Lines={5}",
                    trans.ID, trans.Date, NewServiceCenter.Customers.FindLast(x => x.ID == trans.CustomerID).TIN,
                    NewServiceCenter.Cars.FindLast(x => x.ID == trans.CarID).CarRegistrationPlate, trans.TotalPrice, lines));

                lines = string.Empty;

            }

            MyJsonHandler.SerializeToJson(NewServiceCenter);



            //return transactions;
        }



        private void ctrlDeleteTransaction_Click(object sender, EventArgs e) {

            DeleteSelectedRecord();

            RefreshTransactionsList();
        }

        private void ctrlRefreshTransaction_Click(object sender, EventArgs e) {


            RefreshTransactionsList();
        }

        private void ctrlDisplayTransactions_MouseEnter(object sender, EventArgs e) {
            //RefreshTransactionsList();
        }

        private void ViewTransactionForm_MouseEnter(object sender, EventArgs e) {
            //RefreshTransactionsList();
        }

        private void ViewTransactionForm_MouseLeave(object sender, EventArgs e) {
            //RefreshTransactionsList();
        }

        private void ViewTransactionForm_Load(object sender, EventArgs e) {


            RefreshTransactionsList();
        }
    }
}
