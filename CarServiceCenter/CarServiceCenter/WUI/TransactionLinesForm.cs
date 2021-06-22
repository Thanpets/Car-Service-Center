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
    public partial class TransactionLinesForm : Form {

        //public ServiceCenter NewNewServiceCenter { get; set; }
        public TransactionLine NewTransactionLine { get; set; }

        public TransactionLinesForm() {
            InitializeComponent();
        }


        private void ctrlOK_Click(object sender, EventArgs e) {

            NewTransactionLine.Hours = Convert.ToInt32(ctrlHours.Value);

            


            DialogResult = DialogResult.OK;

        }

        private void ctrlCancel_Click(object sender, EventArgs e) {

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
