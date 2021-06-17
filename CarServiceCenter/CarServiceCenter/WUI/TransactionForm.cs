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

        public TransactionForm() {
            InitializeComponent();
        }

        





        private void ctrlOK_Click(object sender, EventArgs e) {

            if (ctrlCustomers.Items.Count!=0 || ctrlCars.Items.Count!=0 || ctrlTransactionLines.Items.Count!=0) {








            }

            else {

                MessageBox.Show("All fields are required.");
            }





        }

            private void ctrlCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void ctrlTransactionLines_ItemCheck(object sender, ItemCheckEventArgs e) {


            TransactionLine transactionLine = new TransactionLine();

            transactionLinesForm = new TransactionLinesForm() {
                // MdiParent = this,

                NewNewServiceCenter = NewServiceCenter,
                NewNewTransaction = NewTransaction
            };

            DialogResult result = transactionLinesForm.ShowDialog();

            switch (result) {

                case DialogResult.OK:

                    NewTransaction.TransactionLines.Add(transactionLine);
                    NewServiceCenter.Transactions.Add(NewTransaction);

                    break;

                case DialogResult.Cancel:

                    break;

                default:
                    break;
            }

        }

        private void TransactionForm_Load(object sender, EventArgs e) {



            foreach (var item in NewServiceCenter.Customers) {



            ctrlCustomers.Items.Add(Convert.ToString(item.Name));

            }





        }
    }
}
