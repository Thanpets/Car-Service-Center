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

        public Customer MyCustomer { get; set; }

        public CustomerForm() {
            InitializeComponent();
        }

        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ctrlOk_Click(object sender, EventArgs e) {

            GetValue();
        }

        private void GetValue() {

            if (ctrlName.EditValue.ToString().Length > 0) {

                MyCustomer.Name = Convert.ToString(ctrlName.EditValue);
                MyCustomer.Surname = Convert.ToString(ctrlSurname.EditValue);
                MyCustomer.Phone = Convert.ToString(ctrlPhone.EditValue);
                MyCustomer.TIN = Convert.ToString(ctrlTIN.EditValue);

                DialogResult = DialogResult.OK;

                Close();
            }
            else {
                MessageBox.Show("Plese enter Name!");
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e) {
           

            if (!string.IsNullOrWhiteSpace(MyCustomer.Name)) {

                ctrlName.EditValue = MyCustomer.Name;
                ctrlSurname.EditValue = MyCustomer.Surname;
                ctrlPhone.EditValue = MyCustomer.Phone;
                ctrlTIN.EditValue = MyCustomer.TIN;

            }

        }
    }
}
