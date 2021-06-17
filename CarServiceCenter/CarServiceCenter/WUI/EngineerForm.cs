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
    public partial class EngineerForm : Form {


        public Engineer MyEngineer { get; set; }

        public EngineerForm() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            CheckValues();
        }

        private void CheckValues() {
            decimal j = -1;

            if (ctrlNameTextEdit.EditValue.ToString().Length == 0 || ctrlSurnameTextEdit.EditValue.ToString().Length == 0) {
                MessageBox.Show("Please insert Name!");
            }
            else if (ctrlSalaryTextEdit.EditValue.ToString().Length == 0) {
                MessageBox.Show("Please insert Salary!");
            }
            else if (!decimal.TryParse(ctrlSalaryTextEdit.EditValue.ToString(), out j)) {
                MessageBox.Show("Salary must be a Number!");
            }
            else {

                MyEngineer.Name = Convert.ToString(ctrlNameTextEdit.EditValue);
                MyEngineer.Surname = Convert.ToString(ctrlSurnameTextEdit.EditValue);
                MyEngineer.SalaryPerMonth = Convert.ToInt32(ctrlSalaryTextEdit.EditValue);

                DialogResult = DialogResult.OK;
                
            }


        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            
        }

        private void EngineerForm_Load(object sender, EventArgs e) {

            ctrlNameTextEdit.EditValue = MyEngineer.Name;
            ctrlSurnameTextEdit.EditValue = MyEngineer.Surname;
            ctrlSalaryTextEdit.EditValue = MyEngineer.SalaryPerMonth;
        }
    }

}
