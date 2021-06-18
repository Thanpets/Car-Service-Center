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

            if (string.IsNullOrWhiteSpace(ctrlNameTextEdit.EditValue.ToString()) || string.IsNullOrWhiteSpace(ctrlSurnameTextEdit.EditValue.ToString())) {
                MessageBox.Show("Please insert Name!");
            } 
            else if(ctrlEngineerDate.EditValue == null) {
                
                MessageBox.Show("Please insert Date!");

            }
            else {

                MyEngineer.Name = Convert.ToString(ctrlNameTextEdit.EditValue);
                MyEngineer.Surname = Convert.ToString(ctrlSurnameTextEdit.EditValue);
                MyEngineer.SalaryPerMonth = ctrlSalary.Value;
                MyEngineer.HiringDate = Convert.ToDateTime(ctrlEngineerDate.EditValue).Date.ToString("dd/MM/yyyy");

                DialogResult = DialogResult.OK;

            }


        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;

        }

        private void EngineerForm_Load(object sender, EventArgs e) {

            if (!string.IsNullOrWhiteSpace(MyEngineer.Name)) {

                ctrlNameTextEdit.EditValue = MyEngineer.Name;
                ctrlSurnameTextEdit.EditValue = MyEngineer.Surname;
                ctrlSalary.Value = MyEngineer.SalaryPerMonth;
                ctrlEngineerDate.EditValue = MyEngineer.HiringDate; 
            }


        }
    }

}
