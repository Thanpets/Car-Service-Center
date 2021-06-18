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
            LoadData();
        }

        private void ctrlEditCar_Click(object sender, EventArgs e) {
            EditSelectedRecord();
            RefreshItems();
        }

        private void crtlDeleteCar_Click(object sender, EventArgs e) {
            DeleteSelectedRecord();
        }

        private void crtlRefreshCar_Click(object sender, EventArgs e) {
            RefreshItems();
        }

        private void crtlViewCarList_MouseDoubleClick(object sender, MouseEventArgs e) {
            EditSelectedRecord();
            RefreshItems();
        }
        private void LoadData() {
            foreach (var item in CarsList) {

                crtlViewCarList.Items.Add(item);

            }
        }

        private void EditSelectedRecord() {

            Guid id = GetListID();
            if (id == Guid.Empty)
            {
                MessageBox.Show("You have to select an Item");
            }
            else
            {
                Car car = serviceCenter.Cars.Find(x => x.ID == id);
                CarForm form = new CarForm();
                form.NewCar = car;
                form.ShowDialog();
            }
        }
        private Guid GetListID() {
            object listSelection = crtlViewCarList.SelectedItem;
            if (listSelection == null)
            {
                return Guid.Empty;
            }

            List<string> listParse = listSelection.ToString().Split(',').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(3));
            return id;
        }

        private void DeleteSelectedRecord() {
            Guid id = GetListID();
            if (id == Guid.Empty)
            {
                MessageBox.Show("You have to select an Item");
            }
            else
            {
                serviceCenter.Cars.RemoveAll(x => x.ID == id);
                RefreshItems();
            }
        }
        private void RefreshItems() {

            crtlViewCarList.Items.Clear();
            CarsList.Clear();


            foreach (Car item in serviceCenter.Cars) {
                CarsList.Add(string.Format("ID: {3}, Brand: {0}, Car Registration Plate: {1}, Model: {2}",
                            item.Brand, item.CarRegistrationPlate, item.Model,item.ID));
            }

            LoadData();
        }

        
    }
}
