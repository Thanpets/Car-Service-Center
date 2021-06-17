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
    public partial class CarViewForm : Form {
        public List<string> CarsList { get; set; }
        public ServiceCenter serviceCenter { get; set; }
        public CarViewForm() {
            InitializeComponent();
        }

        private void CarViewForm_Load(object sender, EventArgs e) {

            crtlViewCarList.Items.Clear();
            foreach (var item in CarsList) {

                crtlViewCarList.Items.Add(item);

            }
        }
    }
}
