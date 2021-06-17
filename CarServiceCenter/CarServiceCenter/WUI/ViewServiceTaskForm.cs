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

        public List<string> serviceTasks = null;

        public ServiceCenter NewServiceCenter { get; set; }

        public ViewServiceTaskForm() {
            InitializeComponent();
        }

        private void ViewServiceTaskForm_Load(object sender, EventArgs e) {

            //ctrlDisplayServiceTasks.Items.Clear();

            //RefreshView();

            RefreshServiceTasksList();
        }



        private List<string> RefreshServiceTasksList() {

            ctrlDisplayServiceTasks.Items.Clear();
            serviceTasks = new List<string>();

            serviceTasks.Clear();

            foreach (ServiceTask task in NewServiceCenter.ServiceTasks) {

                ctrlDisplayServiceTasks.Items.Add(string.Format("ID={0}\tCode={1}\tDescription={2}\tPricePerHour={3}", task.ID, task.Code, task.Description, task.PricePerHour));
            }

            return serviceTasks;
        }


        private void RefreshView() {

            ctrlDisplayServiceTasks.Items.Clear();

            foreach (var item in NewServiceCenter.ServiceTasks) {

                ctrlDisplayServiceTasks.Items.Add(item.ToString());

            }
        }

        private void EditSelectedRecord() {

            Guid id = GetListID();

            if (id==Guid.Empty) {
                MessageBox.Show("ERROR");
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

            object listSelection = ctrlDisplayServiceTasks.SelectedItem;

            if (listSelection==null) {
                
                //MessageBox.Show("You must specify an entry.");
                return Guid.Empty;

            }


            List<string> listParse = listSelection.ToString().Split('\t').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(3));

            return id;
        }


        private void DeleteSelectedRecord() {

            Guid id = GetListID();

            if (id!=Guid.Empty) {

            NewServiceCenter.ServiceTasks.RemoveAll(x => x.ID == id);
            }
            else {

                MessageBox.Show("ERROR");
            }
        }





        private void ctrlEditServiceTask_Click(object sender, EventArgs e) {


            EditSelectedRecord();
            //RefreshView();

            RefreshServiceTasksList();





        }

        private void ctrlDeleteServiceTask_Click(object sender, EventArgs e) {
            DeleteSelectedRecord();
            //RefreshView();

            RefreshServiceTasksList();
        }

        private void ctrlRefreshServiceTask_Click(object sender, EventArgs e) {


            //RefreshView();

            RefreshServiceTasksList();

        }

        private void ctrlDisplayServiceTasks_MouseDoubleClick(object sender, MouseEventArgs e) {

            //EditSelectedRecord();
            //RefreshView();
          //  GetListID();

            int index = ctrlDisplayServiceTasks.IndexFromPoint(e.Location);

            if (index != -1) {

                if (ctrlDisplayServiceTasks.SelectedItem == null) {

                    ctrlDisplayServiceTasks.SelectedItem = ctrlDisplayServiceTasks.Items[index];

                }

                EditSelectedRecord();

            }

        }



    }
}
