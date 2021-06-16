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
    public partial class CustomerForm : Form {

        public Customer NewCustomer { get; set; }

        public CustomerForm() {
            InitializeComponent();
        }

        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ctrlOk_Click(object sender, EventArgs e) {

            if(ctrlName.EditValue.ToString().Length > 0) {
                NewCustomer.Name = Convert.ToString(ctrlName.EditValue);
                NewCustomer.Surname = Convert.ToString(ctrlSurname.EditValue);
                NewCustomer.Phone = Convert.ToString(ctrlPhone.EditValue);
                NewCustomer.TIN = Convert.ToString(ctrlTIN.EditValue);

                DialogResult = DialogResult.OK;
            }
            else {
                MessageBox.Show("Plese enter Name!");
            }

        }
    }
}
