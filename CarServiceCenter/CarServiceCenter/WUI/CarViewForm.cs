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

        public ServiceCenter serviceCenter { get; set; }
        private JsonHandler MyJsonHandler { get; set; }

        public CarViewForm() {
            InitializeComponent();
            MyJsonHandler = new JsonHandler();
        }

        private void CarViewForm_Load(object sender, EventArgs e) {

            crtlViewCarList.Items.Clear();

            crtlViewCarList.View = View.Details;
            crtlViewCarList.Columns.Add("Brand", 250);
            crtlViewCarList.Columns.Add("Model", 250);
            crtlViewCarList.Columns.Add("Registration Plate", 250);
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
            foreach (var item in serviceCenter.Cars) {
                string StringWithoutID = string.Format("{0},{1},{2}", item.Brand, item.Model, item.CarRegistrationPlate);
                string[] listParse = StringWithoutID.Split(',').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                crtlViewCarList.Items.Add(listViewItem);

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
            if (crtlViewCarList.SelectedItems.Count == 0) {
                return Guid.Empty;
            }

            int index = crtlViewCarList.SelectedIndices[0];
            return serviceCenter.Cars[index].ID;
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

            LoadData();
            MyJsonHandler.SerializeToJson(serviceCenter);
        }

        
    }
}
