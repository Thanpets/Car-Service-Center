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
    public partial class CustomerEditForm : Form {

        public object EditObject { get; set; }

        public CustomerEditForm() {
            InitializeComponent();
        }

        private void BtnOk_Click(object sender, EventArgs e) {

            if (ctrlName.EditValue.ToString().Length > 0) {

                Customer customer = EditObject as Customer;
                customer.Name = Convert.ToString(ctrlName.EditValue);
                customer.Surname = Convert.ToString(ctrlSurname.EditValue);
                customer.Phone = Convert.ToString(ctrlPhone.EditValue);
                customer.TIN = Convert.ToString(ctrlTIN.EditValue);

            }
            else {
                MessageBox.Show("");
            }

        }

        private void CustomerEditForm_Load(object sender, EventArgs e) {

            Customer customer = EditObject as Customer;

            ctrlName.EditValue = customer.Name;
            ctrlSurname.EditValue = customer.Surname;
            ctrlPhone.EditValue = customer.Phone;
            ctrlTIN.EditValue = customer.TIN;
        }
    }
}
