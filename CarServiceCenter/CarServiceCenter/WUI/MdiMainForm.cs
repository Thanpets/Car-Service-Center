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
    public partial class MdiMainForm : Form {
        public MdiMainForm() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Application.Exit();
        }

        private void crtlAddCar_Click(object sender, EventArgs e) {

        }
        private void AddNewCar() {
            CarForm car = new CarForm();

            CarForm form = new CarForm();
            form.NewStudent = student;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    CodingSchool.Students.Add(student);
                    break;

                default:
                    // messagge  ?
                    break;
            }
        }
    }
}
