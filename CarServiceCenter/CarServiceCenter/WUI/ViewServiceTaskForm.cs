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


        public List<string> ServiceTasksList { get; set; }
        public ServiceCenter NewServiceCenter { get; set; }

        public ViewServiceTaskForm() {
            InitializeComponent();
        }

        private void ViewServiceTaskForm_Load(object sender, EventArgs e) {

            //ctrlDisplayServiceTasks.Items.Clear();

            RefreshView();

        }

        public void RefreshView() {

            ctrlDisplayServiceTasks.Items.Clear();

            foreach (var item in ServiceTasksList) {

                ctrlDisplayServiceTasks.Items.Add(item);

            }
        }
        private void EditSelectedRecord() {

            Guid id = GetListID();

            ServiceTask serviceTask = NewServiceCenter.ServiceTasks.Find(x => x.ID == id);

            ServiceTaskForm form = new ServiceTaskForm();
            form.NewServiceTask = serviceTask;
            form.NewServiceCenter = NewServiceCenter;
            form.ShowDialog();
        }

        private Guid GetListID() {

            object listSelection = ctrlDisplayServiceTasks.SelectedItem;

            List<string> listParse = listSelection.ToString().Split('\t').ToList();

            Guid id = Guid.Parse(listParse[0].Substring(3));

            return id;
        }
        private void DeleteSelectedRecord() {

            Guid id = GetListID();
            NewServiceCenter.ServiceTasks.RemoveAll(x => x.ID == id);
        }





        private void ctrlEditServiceTask_Click(object sender, EventArgs e) {


            EditSelectedRecord();
            RefreshView();
       
        
        
        
        
        
        }

        private void ctrlDeleteServiceTask_Click(object sender, EventArgs e) {
            DeleteSelectedRecord();
            RefreshView();
        }

        private void ctrlRefreshServiceTask_Click(object sender, EventArgs e) {
            RefreshView();
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
