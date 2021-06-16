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
            NewCar.Brand = Convert.ToString(crtlBrand.EditValue);
            NewCar.CarRegistrationPlate = Convert.ToString(crtlCarRegistrationPlate.EditValue);
            NewCar.Model = Convert.ToString(crtlModel.EditValue);
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
