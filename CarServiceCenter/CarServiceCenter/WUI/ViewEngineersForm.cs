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
    public partial class ViewEngineersForm : Form {

        public List<string> EngineersList { get; set; }
        public ServiceCenter serviceCenter { get; set; }

        public ViewEngineersForm() {
            InitializeComponent();
        }

        private void ViewEngineersForm_Load(object sender, EventArgs e) {

            ctrlEngineersListView.Items.Clear();
            LoadData();
        }

        private void LoadData() {
            foreach (var item in EngineersList) {

                ctrlEngineersListView.Items.Add(item);

            }
        }

        private void EditSelectedRecord() {

            Guid id = GetListID();

            if (id == Guid.Empty) {
                MessageBox.Show("You have to select an Item");
            }
            else {

                Engineer engineer = serviceCenter.Engineers.Find(x => x.ID == id);

                EngineerForm form = new EngineerForm();
                form.MyEngineer = engineer;
                form.ShowDialog();
            }
        }

        private Guid GetListID() {

           
            object listSelection = ctrlEngineersListView.SelectedItem;
            if (listSelection == null) {
                return Guid.Empty;
            }
            List<string> listParse = listSelection.ToString().Split(',').ToList();
    
            Guid id = Guid.Parse(listParse[0].Substring(3));        
            
            return id;
        }

        private void btnDeleteEngineer_Click(object sender, EventArgs e) {
            DeleteSelectedRecord();
            RefreshItems();
        }

        private void DeleteSelectedRecord() {
            Guid id = GetListID();

            if (id == Guid.Empty) {
                MessageBox.Show("You have to select an Item");
            }
            else {
                serviceCenter.Engineers.RemoveAll(x => x.ID == id);
            }
        }

        private void RefreshItems() {

            ctrlEngineersListView.Items.Clear();
            EngineersList.Clear();

            foreach (Engineer item in serviceCenter.Engineers) {
                EngineersList.Add(string.Format("ID: {3}, Name: {0}, Surname: {1}, Salary: {2}",
                    item.Name, item.Surname, item.SalaryPerMonth, item.ID));
            }

            LoadData();

        }

        private void ctrlEngineersListView_MouseDoubleClick(object sender, MouseEventArgs e) {
            EditSelectedRecord();
            RefreshItems();
        }

        

        private void btnResfreshEngineers_Click(object sender, EventArgs e) {
            RefreshItems();
        }

        private void ctrlEditEngineer_Click(object sender, EventArgs e) {
            EditSelectedRecord();
            RefreshItems();
        }
    }  
}
