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
    public partial class TransactionForm : Form {

        public ServiceCenter NewServiceCenter { get; set; }

        public Transaction NewTransaction { get; set; }

        private TransactionLinesForm transactionLinesForm = null;

        private TransactionLine transactionLine = null;

        private string checkBoxSelectedItem = null;


        public TransactionForm() {
            InitializeComponent();
        }



        private void ctrlOK_Click(object sender, EventArgs e) {
            AddTransaction();

        }

        private void AddTransaction() {
            if (ctrlCustomers.SelectedItems.Count > 0 && ctrlCars.SelectedItems.Count > 0 && ctrlTransactionLines.CheckedItems.Count > 0) {


                int currentCustomer = ctrlCustomers.SelectedIndices[0];
                int currentCar = ctrlCars.SelectedIndices[0];

                decimal total = 0m;

                NewTransaction.Date = Convert.ToString(ctrlDate.Value.Date);
                

                NewTransaction.CustomerID = NewServiceCenter.Customers[currentCustomer].ID;

                NewTransaction.CarID = NewServiceCenter.Cars[currentCar].ID;


                foreach (var item in NewTransaction.TransactionLines) {
                    total += item.Price;
                }

                NewTransaction.TotalPrice = total;

                DialogResult = DialogResult.OK;
            }

            else {

                MessageBox.Show("All fields are required.");
            }
        }

        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;

            Close();
        }



        private void TransactionForm_Load(object sender, EventArgs e) {
            PopulateListBoxes();

            //ctrlCustomers.Items.Clear();
        }

        private void PopulateListBoxes() {

            ctrlCustomers.Items.Clear();

            ctrlCustomers.View = View.Details;
            ctrlCustomers.Columns.Add("Name", 80);
            ctrlCustomers.Columns.Add("Last Name", 80);
            ctrlCustomers.Columns.Add("Phone", 80);
            ctrlCustomers.Columns.Add("TIN", 80);
            //ctrlCustomers.Items.Add(string.Format("{0}\t\t\t\t\t\t\t\t{1}", Convert.ToString(item.TIN), Convert.ToString(item.ID)));
            


            ctrlCars.Items.Clear();
            ctrlCars.View = View.Details;
            ctrlCars.Columns.Add("Brand", 100);
            ctrlCars.Columns.Add("Model", 100);
            ctrlCars.Columns.Add("Registration Plate", 100);


            LoadData();


           
            foreach (var item in NewServiceCenter.ServiceTasks) {

                ctrlTransactionLines.Items.Add(string.Format("{0}\t\t\t\t\t\t\t\t\t{1}", Convert.ToString(item.Description), Convert.ToString(item.ID)));
            }
        }

        private void ctrlTransactionLines_MouseClick(object sender, MouseEventArgs e) {
            AddTransactionLine();
        }

        private void LoadData() {

            foreach (var item in NewServiceCenter.Cars) {
                string StringWithoutID = string.Format("{0},{1},{2}", item.Brand, item.Model, item.CarRegistrationPlate);
                string[] listParse = StringWithoutID.Split(',').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                ctrlCars.Items.Add(listViewItem);

            }

            foreach (var item in NewServiceCenter.Customers) {
                string StringWithoutID = string.Format("{0},{1},{2},{3}", item.Name, item.Surname, item.Phone, item.TIN);
                string[] listParse = StringWithoutID.Split(',').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                ctrlCustomers.Items.Add(listViewItem);

            }

        }

       
        private void AddTransactionLine() {

            for (int i = 0; i < ctrlTransactionLines.Items.Count; i++) {

                if (ctrlTransactionLines.GetItemRectangle(i).Contains(ctrlTransactionLines.PointToClient(MousePosition))) {
                    switch (ctrlTransactionLines.GetItemCheckState(i)) {
                        case CheckState.Checked:
                         string   checkBoxSelectedItem1 = Convert.ToString(ctrlTransactionLines.Items[i]);

                            ServiceTask task = NewServiceCenter.ServiceTasks.Find(x => x.ID == Guid.Parse(checkBoxSelectedItem1.Substring(Math.Max(0, checkBoxSelectedItem1.Length - 36))));

                            string tmp = string.Format("{0}\t\t\t\t\t\t\t\t\t{1}", task.Description, task.ID);

                            ctrlTransactionLines.Items[i] = tmp;

                            NewTransaction.TransactionLines.RemoveAll(x => x.ServiceTaskID == Guid.Parse(checkBoxSelectedItem1.Substring(Math.Max(0, checkBoxSelectedItem1.Length - 36))));

                            ctrlTransactionLines.SetItemCheckState(i, CheckState.Unchecked);

                            break;
                        case CheckState.Indeterminate:
                        case CheckState.Unchecked:

                            ctrlTransactionLines.SetItemCheckState(i, CheckState.Checked);

                            checkBoxSelectedItem = Convert.ToString(ctrlTransactionLines.Items[i]);

                          
                            ServiceTask task1 = NewServiceCenter.ServiceTasks.Find(x => x.ID == Guid.Parse(checkBoxSelectedItem.Substring(Math.Max(0, checkBoxSelectedItem.Length - 36))));
                            transactionLine = new TransactionLine() {
                                ServiceTaskID = task1.ID
                            };
                            transactionLinesForm = new TransactionLinesForm() {
                                //NewNewServiceCenter = NewServiceCenter,
                                NewTransactionLine = transactionLine
                            };
                            DialogResult result = transactionLinesForm.ShowDialog();
                            switch (result) {
                                case DialogResult.OK:
                                    

                                    transactionLine.Price = transactionLine.Hours * task1.PricePerHour;
                                    
                                    NewTransaction.TransactionLines.Add(transactionLine);

                                    string tmp1 = string.Format("{0}\t\t{1} hour(s) x {2} euros per hour\t\t\t\t{3}", task1.Description, transactionLine.Hours, task1.PricePerHour, task1.ID);

                                    ctrlTransactionLines.Items[i] = tmp1;

                                    break;
                                case DialogResult.Cancel:
                                   
                                  string  checkBoxSelectedItem2 = Convert.ToString(ctrlTransactionLines.Items[i]);

                                    ServiceTask task2 = NewServiceCenter.ServiceTasks.Find(x => x.ID == Guid.Parse(checkBoxSelectedItem2.Substring(Math.Max(0, checkBoxSelectedItem2.Length - 36))));

                                    string tmp2 = string.Format("{0}\t\t\t\t\t\t\t\t\t{1}", task2.Description, task2.ID);

                                    ctrlTransactionLines.Items[i] = tmp2;

                                    NewTransaction.TransactionLines.RemoveAll(x => x.ServiceTaskID == Guid.Parse(checkBoxSelectedItem2.Substring(Math.Max(0, checkBoxSelectedItem2.Length - 36))));

                                    ctrlTransactionLines.SetItemCheckState(i, CheckState.Unchecked);

                                    break;
                                default:
                                    break;
                            }
                           
                            break;
                    }

                }
                
            }

        }

    }
}
