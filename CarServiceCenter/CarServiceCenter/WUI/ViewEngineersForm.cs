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

            foreach (var item in EngineersList) {

                ctrlEngineersListView.Items.Add(item);

            }
        }

        private void btnEditEngineer_Click(object sender, EventArgs e) {
            EditSelectedRecord();
        }

        private void EditSelectedRecord() {

            Guid id = GetListID();

            Engineer engineer = serviceCenter.Engineers.Find(x => x.ID == id);
        }

        private Guid GetListID() {
            Engineer listSelection = (Engineer)ctrlEngineersListView.SelectedItem;
            List<string> listParse = listSelection.ToString().Split(' ').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(3));
            return id;
        }

        private void btnDeleteEngineer_Click(object sender, EventArgs e) {

        }

        private void btnResfreshEngineer_Click(object sender, EventArgs e) {

        }

        private void ctrlEngineerListView_MouseDoubleClick(object sender, MouseEventArgs e) {
            EditSelectedRecord();
        }
    }
}
