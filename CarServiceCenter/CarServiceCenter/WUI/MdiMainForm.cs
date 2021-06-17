using CarServiceCenter.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace CarServiceCenter.WUI {
    public partial class MdiMainForm : Form {


        private const string _JsonFile = "CarServiceCenterData.json";


        private ServiceCenter serviceCenter = null;
        private ServiceTaskForm serviceTaskForm = null;
        private List<string> serviceTasks = null;
    //private    ServiceTaskForm serviceTaskForm = null;



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

            form.MdiParent = this;
            form.Show();
            serviceCenter.Cars.Add(car);
        }
        private void crtlCarView_Click(object sender, EventArgs e) {

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


            switch (DialogResult.OK) {
                case DialogResult.OK:

                    serviceCenter.Customers.Add(customer);

                    break;

                default:
            }

        }

        private void ctrlAddServiceTask_Click(object sender, EventArgs e) {

            ServiceTask serviceTask = new ServiceTask();

             serviceTaskForm = new ServiceTaskForm() {
                MdiParent = this,

                NewServiceTask = serviceTask,
                NewServiceCenter = serviceCenter
            };

            serviceTaskForm.Show();



           


        }

        private List<string> RefreshServiceTasksList() {


            serviceTasks = new List<string>();

            serviceTasks.Clear();

            foreach (ServiceTask task in serviceCenter.ServiceTasks) {

                serviceTasks.Add(string.Format("ID={0} \t Code={1} \t Description={2} \t PricePerHour={3}", task.ID, task.Code, task.Description, task.PricePerHour));
            }


            return serviceTasks;
        }

        private void ctrlViewServiceTask_Click(object sender, EventArgs e) {


            ViewServiceTaskForm viewServiceTask = new ViewServiceTaskForm() {

                MdiParent=this,
                
                ServiceTasksList= RefreshServiceTasksList()
            };

            viewServiceTask.Show();


        }

        private void ctrlAddEngineer_Click(object sender, EventArgs e) {
            AddEngineer();
        }

        private void AddEngineer() {
            Engineer engineer = new Engineer();

            EngineerForm engineerForm = new EngineerForm();
            engineerForm.MyEngineer = engineer;

            engineerForm.MdiParent = this;
            engineerForm.Show();
            serviceCenter.Engineers.Add(engineer);

        }

        private void SerializeToJson(object objectToBeSerialized) {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string data = serializer.Serialize(objectToBeSerialized);

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            File.WriteAllText(path, data);
        }


        private void DeserializeFromJson() {

            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string path = Path.Combine(Environment.CurrentDirectory, _JsonFile);

            string data = string.Empty;

            if (File.Exists(path)) {

                data = File.ReadAllText(path);

                serviceCenter = serializer.Deserialize<ServiceCenter>(data);
            }
            else {


                File.Create(path).Dispose();

                serviceCenter = new ServiceCenter() {


                    Name = "CarServiceCenterName",
                    Customers = new List<Customer>(),
                    Cars = new List<Car>(),
                    Engineers = new List<Engineer>(),
                    Transactions = new List<Transaction>(),
                    ServiceTasks = new List<ServiceTask>(),
                    MonthlyLedgers = new List<MonthlyLedger>()


                };

                SerializeToJson(serviceCenter);

            }





        }


        private void MdiMainForm_Load(object sender, EventArgs e) {

            DeserializeFromJson();

        //    serviceCenter = new ServiceCenter() {


        //        Name = "CarServiceName",
        //    Customers = new List<Customer>(),
        //    Cars = new List<Car>(),
        //    Engineers = new List<Engineer>(),
        //    Transactions = new List<Transaction>(),
        //    ServiceTasks = new List<ServiceTask>(),
        //    MonthlyLedgers = new List<MonthlyLedger>()



        //};
          //  };
        }

     

        private List<string> GetCustomerList() {

            List<string> customerList = new List<string>();

            try {
               
                if (serviceCenter?.Customers != null) {
                
                    foreach (Customer item in serviceCenter.Customers) {
                        customerList.Add(string.Format("ID: {4}, Name: {0}, Surname: {1}, Phone: {2}, TIN: {3}",
                            item.Name, item.Surname, item.Phone, item.TIN, item.ID));
                    }
                }
                else {
                    MessageBox.Show("No Customer Exists!");
                }
            }
            catch (Exception ex) {

                MessageBox.Show("Something wrong happened", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return customerList;
        }

        private void viewToolStripMenuItem_Click_1(object sender, EventArgs e) {
            ViewCustomers();
        }

        private void ViewCustomers() {
            CustomerViewForm viewForm = new CustomerViewForm();

         //   viewForm.MdiParent = this;
            viewForm.ViewCustomerData = GetCustomerList();
            viewForm.serviceCenter = serviceCenter;
            viewForm.Show();
        }

        private void ctrlViewEngineer_Click(object sender, EventArgs e) {
            ViewEngineers();
        }

        private void ViewEngineers() {

            ViewEngineersForm viewEngineerForm = new ViewEngineersForm();
            viewEngineerForm.MdiParent = this;

            viewEngineerForm.EngineersList = GetEngineersList();

            viewEngineerForm.Show();
        }

        private void MdiMainForm_Activated(object sender, EventArgs e) {
            //SerializeToJson(serviceCenter);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void MdiMainForm_MdiChildActivate(object sender, EventArgs e) {
            SerializeToJson(serviceCenter);
        }


        private List<string> GetEngineersList() {

            List<string> engineersList = new List<string>();

            try {

                if (serviceCenter?.Engineers != null) {

                    foreach (Engineer item in serviceCenter.Engineers) {
                        engineersList.Add(string.Format("Name: {0}, Surname: {1}, Salary: {2}",
                            item.Name, item.Surname, item.SalaryPerMonth));
                    }
                }
                else {
                    MessageBox.Show("No Engineer Exists!");
                }
            }
            catch (Exception ex) {

                MessageBox.Show("Something wrong happened", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return engineersList;
        }

        
    }
}
