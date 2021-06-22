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
    public partial class MonthlyLedgerForm : Form {

        public ServiceCenter MyServiceCenter { get; set; }
      
        public MonthlyLedgerForm() {
            InitializeComponent();
        }

        private void MonthlyLedgerForm_Load(object sender, EventArgs e) {


            ctrlMontlyList.Items.Clear();

            ctrlMontlyList.View = View.Details;
            ctrlMontlyList.Columns.Add("Date", 150);
            ctrlMontlyList.Columns.Add("Income", 150);
            ctrlMontlyList.Columns.Add("Expanses", 150);
            ctrlMontlyList.Columns.Add("Total", 150);
            LoadData();

        }

        private void LoadData() {

            foreach (var item in MyServiceCenter.MonthlyLedgers) {
                string date = DateTime.Parse(item.Date).Month + "/" + DateTime.Parse(item.Date).Year;
                string StringWithoutID = string.Format("{0}.{1}.{2}.{3}", date, item.Income, item.Expenses.ToString("F"), item.Total.ToString("F"));
                string[] listParse = StringWithoutID.Split('.').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                ctrlMontlyList.Items.Add(listViewItem);

            }

        }

        private void RefreshItem() {
            ctrlMontlyList.Items.Clear();
            LoadData();
           
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            RefreshItem();
        }
    }
}
