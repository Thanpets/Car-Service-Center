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

        public ServiceCenter NewNewServiceCenter { get; set; }
        public Transaction NewNewTransaction { get; set; }

        public TransactionLinesForm() {
            InitializeComponent();
        }

       

        private void ctrlOK_Click(object sender, EventArgs e) {







            DialogResult = DialogResult.OK;

        }

        private void ctrlCancel_Click(object sender, EventArgs e) {

            this.DialogResult = DialogResult.Cancel;

            Close();
        }
    }
}
