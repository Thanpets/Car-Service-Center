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
       private TransactionLine transactionLine;
        public TransactionForm() {
            InitializeComponent();
        }







        private void ctrlOK_Click(object sender, EventArgs e) {

            if (ctrlCustomers.Items.Count != 0 && ctrlCars.Items.Count != 0 && ctrlTransactionLines.Items.Count != 0) {

                decimal total=0m;

                NewTransaction.Date = ctrlDate.Value.Date;
                NewTransaction.CustomerID = Guid.Parse(Convert.ToString(ctrlCustomers.SelectedItem));

                NewTransaction.CarID = Guid.Parse(Convert.ToString(ctrlCars.SelectedItem));

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

                ctrlCustomers.Items.Add(Convert.ToString(item.ID));
            }

            foreach (var item in NewServiceCenter.Cars) {

                ctrlCars.Items.Add(Convert.ToString(item.ID));
            }

            foreach (var item in NewServiceCenter.ServiceTasks) {

                ctrlTransactionLines.Items.Add(Convert.ToString(item.ID));
            }

        }


        private void ctrlTransactionLines_MouseClick(object sender, MouseEventArgs e) {



            //    if (ctrlTransactionLines.SelectedItem

            //        [ctrlTransactionLines.IndexFromPoint(e.Location)]  ) {


            if (ctrlTransactionLines.GetItemCheckState(ctrlTransactionLines.IndexFromPoint(e.Location)) == CheckState.Checked) {



                ctrlTransactionLines.SetItemChecked(ctrlTransactionLines.IndexFromPoint(e.Location), false);
                NewTransaction.TransactionLines.RemoveAll(x => x.ServiceTaskID == Guid.Parse(ctrlTransactionLines.SelectedItem.ToString()));
            }

            //}
            else {




                ServiceTask task = NewServiceCenter.ServiceTasks.Find(x => x.ID == Guid.Parse(ctrlTransactionLines.SelectedItem.ToString()));


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

                        ctrlTransactionLines.SetItemChecked(ctrlTransactionLines.IndexFromPoint(e.Location), true);

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

                        ctrlTransactionLines.SetItemChecked(ctrlTransactionLines.IndexFromPoint(e.Location), false);

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
