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
    public partial class CarForm : Form {
        public Car NewCar { get; set; }


        public CarForm() {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e) {
            NewCarValidation();

        }

        private void NewCarValidation() {
            var tempbrand = Convert.ToString(crtlBrand.EditValue);
            var tempcarplate = Convert.ToString(crtlCarRegistrationPlate.EditValue);
            var tempmodel = Convert.ToString(crtlModel.EditValue);

            if (string.IsNullOrWhiteSpace(tempbrand)) {
                MessageBox.Show("Please input a brand!");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(tempmodel)) {
                MessageBox.Show("Please input a Car Model");
                return;
            }
            if (string.IsNullOrWhiteSpace(tempcarplate)) {
                MessageBox.Show("Please input a Car Registration Plate");
                return;
            }

            NewCar.Brand = tempbrand;
            NewCar.CarRegistrationPlate = tempcarplate;
            NewCar.Model = tempmodel;
            Close();
        }


        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
