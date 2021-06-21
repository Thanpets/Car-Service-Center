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


        //public List<string> ServiceTasksList { get; set; }
        private JsonHandler MyJsonHandler = null;

        //private List<string> serviceTasks = null;


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



        //private List<string> RefreshServiceTasksList() {
        private void RefreshServiceTasksList() {

            ctrlDisplayServiceTasks.Items.Clear();

            LoadData();
            MyJsonHandler.SerializeToJson(NewServiceCenter);

            //ctrlDisplayServiceTasks.Items.Clear();

            ////serviceTasks = new List<string>();

            ////serviceTasks.Clear();

            //foreach (ServiceTask task in NewServiceCenter.ServiceTasks) {

            //    ctrlDisplayServiceTasks.Items.Add(string.Format("ID={0}\tCode={1}\tDescription={2}\tPricePerHour={3}", task.ID, task.Code, task.Description, task.PricePerHour));
            //}
            //MyJsonHandler.SerializeToJson(NewServiceCenter);

            ////return serviceTasks;
        }


        //private void RefreshView() {

        //    ctrlDisplayServiceTasks.Items.Clear();

        //    foreach (var item in NewServiceCenter.ServiceTasks) {

        //        ctrlDisplayServiceTasks.Items.Add(item.ToString());

        //    }
        //}

        private void EditSelectedRecord() {

            Guid id = GetListID();

            if (id == Guid.Empty) {

                MessageBox.Show("Please specify an entry.");
            }
            else {


                ServiceTask serviceTask = NewServiceCenter.ServiceTasks.Find(x => x.ID == id);

                ServiceTaskForm form = new ServiceTaskForm {
                    NewServiceTask = serviceTask,
                    //NewServiceCenter = NewServiceCenter
                };
                form.ShowDialog();
            }
        }

        private Guid GetListID() {

            //object listSelection = ctrlDisplayServiceTasks.SelectedItem;

            //if (listSelection == null) {

            //    return Guid.Empty;

            //}


            //List<string> listParse = listSelection.ToString().Split('\t').ToList();

            //Guid id = Guid.Parse(listParse[0].Substring(3));

            //return id;

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
