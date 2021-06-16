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
    public partial class MdiMainForm : Form {


        private ServiceCenter serviceCenter = null;
        private ServiceTaskForm serviceTaskForm = null;
        private List<string> serviceTasks = null;

        public MdiMainForm() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Application.Exit();
        }

        private void crtlAddCar_Click(object sender, EventArgs e) {
            AddNewCar();
        }
        private void AddNewCar() {
            Car car = new Car();

            CarForm form = new CarForm();
            form.NewCar = car;

            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:
                    //Cars.Add(car);  
                    break;

                default:
                    // messagge  ?
                    break;
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            AddCustomer();
        }

        public void AddCustomer() {
            Customer customer = new Customer();

            CustomerForm form = new CustomerForm();
            form.MdiParent = this;
            form.NewCustomer = customer;
            form.Show();

            DialogResult result = DialogResult.OK;

            switch (result) {
                case DialogResult.OK:

                  //  serviceCenter.Customers.Add(customer);

                    break;

                default:
                    break;
            }

        }

        private void ctrlAddServiceTask_Click(object sender, EventArgs e) {

            ServiceTask serviceTask = new ServiceTask();

            ServiceTaskForm serviceTaskForm = new ServiceTaskForm() {

                NewServiceTask = serviceTask,
                NewServiceCenter=serviceCenter
            };

            serviceTaskForm.Show();




        }
        private void RefreshServiceTasksList() {

            serviceTasks.Clear();

            foreach (ServiceTask task in serviceCenter.ServiceTasks) {

              serviceTasks.Add(string.Format("{0} \t {1} \t {2} \t {3}", task.ID, task.Code, task.Description, task.PricePerHour));
            }
        }
        private void ctrlViewServiceTask_Click(object sender, EventArgs e) {





        }
    }
}
