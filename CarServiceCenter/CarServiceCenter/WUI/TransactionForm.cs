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

        private int indexFromPoint = 0;

        public TransactionForm() {
            InitializeComponent();
        }



        private void ctrlOK_Click(object sender, EventArgs e) {

            if (ctrlCustomers.SelectedItems.Count > 0 & ctrlCars.SelectedItems.Count > 0 & ctrlTransactionLines.CheckedItems.Count > 0) {


                string currentCustomer = Convert.ToString(ctrlCustomers.SelectedItem);
                string currentCar = Convert.ToString(ctrlCars.SelectedItem);

                decimal total = 0m;


                //unresolved conflict
                NewTransaction.Date = Convert.ToString(ctrlDate.Value.Date);
                //NewTransaction.Date = Convert.ToDateTime(ctrlDate.Value).Date.ToString("dd/MM/yyyy");

                NewTransaction.CustomerID = Guid.Parse(currentCustomer.Substring(Math.Max(0, currentCustomer.Length - 36)));

                NewTransaction.CarID = Guid.Parse(currentCar.Substring(Math.Max(0, currentCar.Length - 36)));

                // NewTransaction.TransactionLines.Add(ctrlTransactionLines.SelectedItems.);

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

        private void ctrlTransactionLines_ItemCheck(object sender, ItemCheckEventArgs e) {




        }

        private void TransactionForm_Load(object sender, EventArgs e) {

            foreach (var item in NewServiceCenter.Customers) {

                ctrlCustomers.Items.Add(string.Format("{0}\t\t\t{1}", Convert.ToString(item.TIN), Convert.ToString(item.ID)));
            }

            foreach (var item in NewServiceCenter.Cars) {

                ctrlCars.Items.Add(string.Format("{0}\t\t\t{1}", Convert.ToString(item.CarRegistrationPlate), Convert.ToString(item.ID)));
            }

            foreach (var item in NewServiceCenter.ServiceTasks) {

                ctrlTransactionLines.Items.Add(string.Format("{0}\t\t\t{1}", Convert.ToString(item.Description), Convert.ToString(item.ID)));
            }

        }


        private void ctrlTransactionLines_MouseClick(object sender, MouseEventArgs e) {

            //    if (ctrlTransactionLines.SelectedItem

            //        [ctrlTransactionLines.IndexFromPoint(e.Location)]  ) {
            indexFromPoint = ctrlTransactionLines.IndexFromPoint(e.Location);

            if (indexFromPoint == -1) {

                MessageBox.Show("Please click on a specific item.");

            }
            else {

                checkBoxSelectedItem = Convert.ToString(ctrlTransactionLines.SelectedItem);



                if (ctrlTransactionLines.GetItemCheckState(indexFromPoint) == CheckState.Checked) {





                    ctrlTransactionLines.SetItemChecked(indexFromPoint, false);

                    NewTransaction.TransactionLines.RemoveAll(x => x.ServiceTaskID == Guid.Parse(checkBoxSelectedItem));
                }

                //}
                else {


                    ServiceTask task = NewServiceCenter.ServiceTasks.Find(x => x.ID == Guid.Parse(checkBoxSelectedItem.Substring(Math.Max(0, checkBoxSelectedItem.Length - 36))));


                    transactionLine = new TransactionLine() {

                        ServiceTaskID = task.ID
                    };

                    transactionLinesForm = new TransactionLinesForm() {
                        // MdiParent = this,

                        NewNewServiceCenter = NewServiceCenter,

                        NewTransactionLine = transactionLine
                    };

                    DialogResult result = transactionLinesForm.ShowDialog();

                    switch (result) {

                        case DialogResult.OK:
                            //if (ctrlTransactionLines.GetItemCheckState(e.Index) == CheckState.Checked) {

                            ctrlTransactionLines.SetItemChecked(indexFromPoint, true);




                            Transaction trans = new Transaction();

                            transactionLine.ServiceTaskID = task.ID;


                            transactionLine.Price = transactionLine.Hours * task.PricePerHour;

                            NewTransaction.TransactionLines.Add(transactionLine);

                            //NewServiceCenter.Transactions.Add(NewTransaction);


                            //}
                            //else {

                            //    ctrlTransactionLines.SetItemChecked(e.Index, true);

                            //}

                            break;

                        case DialogResult.Cancel:

                            ctrlTransactionLines.SetItemChecked(indexFromPoint, false);

                            //NewTransaction.TransactionLines.Remove(transactionLine);

                            //ctrlTransactionLines.IndexFromPoint(e.Location);
                            break;

                        default:
                            break;
                    }

                }
            }

        }
    }
}
