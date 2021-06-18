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


        public ViewTransactionForm() {
            InitializeComponent();
        }


        private void RefreshView() {

            ctrlDisplayTransactions.Items.Clear();

            foreach (var item in NewServiceCenter.Transactions) {

                ctrlDisplayTransactions.Items.Add(item.ToString());

            }
        }

        private Guid GetListID() {

            object listSelection = ctrlDisplayTransactions.SelectedItem;

            if (listSelection == null) {

                return Guid.Empty;

            }


            List<string> listParse = listSelection.ToString().Split('\t').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(3));

            return id;
        }


        private void ctrlDeleteTransaction_Click(object sender, EventArgs e) {

        }

        private void ctrlRefreshTransaction_Click(object sender, EventArgs e) {

        }
    }
}
