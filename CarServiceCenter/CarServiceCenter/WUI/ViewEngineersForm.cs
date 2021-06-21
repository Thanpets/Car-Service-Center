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

        public ServiceCenter serviceCenter { get; set; }
        private JsonHandler MyJsonHandler { get; set; }

        public ViewEngineersForm() {
            InitializeComponent();
            MyJsonHandler = new JsonHandler();
        }


        private void ViewEngineersForm_Load(object sender, EventArgs e) {

            ctrlEngineersListView.Items.Clear();
           
            ctrlEngineersListView.View = View.Details;
            ctrlEngineersListView.Columns.Add("Name", 250);
            ctrlEngineersListView.Columns.Add("Last Name", 250);
            ctrlEngineersListView.Columns.Add("Salary", 250);
            LoadData();
        }

        private void LoadData() {
            foreach (var item in serviceCenter.Engineers) {
                string StringWithoutID = string.Format("{0},{1},{2}", item.Name, item.Surname,item.SalaryPerMonth);
                string[] listParse = StringWithoutID.Split(',').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                ctrlEngineersListView.Items.Add(listViewItem);

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
  
            if (ctrlEngineersListView.SelectedItems.Count == 0) {
                return Guid.Empty;
            }

            int index = ctrlEngineersListView.SelectedIndices[0];
            return serviceCenter.Engineers[index].ID;
    
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
            
            LoadData();
            MyJsonHandler.SerializeToJson(serviceCenter);
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
