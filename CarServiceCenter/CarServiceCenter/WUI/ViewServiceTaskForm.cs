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
    public partial class ViewServiceTaskForm : Form {


        private JsonHandler MyJsonHandler = null;

        public ServiceCenter NewServiceCenter { get; set; }

        public ViewServiceTaskForm() {

            InitializeComponent();
            MyJsonHandler = new JsonHandler();

        }

        private void ViewServiceTaskForm_Load(object sender, EventArgs e) {

            ctrlDisplayServiceTasks.Items.Clear();

            ctrlDisplayServiceTasks.View = View.Details;
            ctrlDisplayServiceTasks.Columns.Add("Code", 50);
            ctrlDisplayServiceTasks.Columns.Add("Description", 450);
            ctrlDisplayServiceTasks.Columns.Add("Price Per Hour", 150);
            LoadData();

            RefreshServiceTasksList();
        }

        private void LoadData() {
            foreach (var item in NewServiceCenter.ServiceTasks) {
                string StringWithoutID = string.Format("{0},{1},{2}", item.Code, item.Description, item.PricePerHour);
                string[] listParse = StringWithoutID.Split(',').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                ctrlDisplayServiceTasks.Items.Add(listViewItem);

            }
        }

        private void RefreshServiceTasksList() {

            ctrlDisplayServiceTasks.Items.Clear();

            LoadData();
            MyJsonHandler.SerializeToJson(NewServiceCenter);

        }

        private void EditSelectedRecord() {

            Guid id = GetListID();

            if (id == Guid.Empty) {

                MessageBox.Show("Please specify an entry.");
            }
            else {


                ServiceTask serviceTask = NewServiceCenter.ServiceTasks.Find(x => x.ID == id);

                ServiceTaskForm form = new ServiceTaskForm {
                    NewServiceTask = serviceTask,
                };
                form.ShowDialog();
            }
        }

        private Guid GetListID() {

           
            if (ctrlDisplayServiceTasks.SelectedItems.Count == 0) {
                return Guid.Empty;
            }

            int index = ctrlDisplayServiceTasks.SelectedIndices[0];
            return NewServiceCenter.ServiceTasks[index].ID;
        }


        private void DeleteSelectedRecord() {

            Guid id = GetListID();

            if (id != Guid.Empty) {

                NewServiceCenter.ServiceTasks.RemoveAll(x => x.ID == id);
            }
            else {

                MessageBox.Show("Please specify an entry.");
            }
        }

        private void ctrlEditServiceTask_Click(object sender, EventArgs e) {

            EditSelectedRecord();

            RefreshServiceTasksList();

        }

        private void ctrlDeleteServiceTask_Click(object sender, EventArgs e) {

            DeleteSelectedRecord();

            RefreshServiceTasksList();
        }

        private void ctrlRefreshServiceTask_Click(object sender, EventArgs e) {

            RefreshServiceTasksList();

        }

        private void ctrlDisplayServiceTasks_MouseDoubleClick(object sender, MouseEventArgs e) {

            EditSelectedRecord();
            RefreshServiceTasksList();
        }

    }
}
