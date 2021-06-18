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


        private ServiceCenter serviceCenter = null;
        private JsonHandler MyJsonHandler { get; set; }
        private ServiceTaskForm serviceTaskForm = null;
        private List<string> serviceTasks = null;
        private TransactionForm transactionForm = null;
        private MonthlyLedger ledger = null;

        public MdiMainForm() {
            InitializeComponent();
            MyJsonHandler = new JsonHandler();
            //serviceCenter = new ServiceCenter();

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

            //form.MdiParent = this;
            //form.Show();
            DialogResult result = form.ShowDialog();
            switch (result) {
                case DialogResult.OK:

                    serviceCenter.Cars.Add(car);
                    MyJsonHandler.SerializeToJson(serviceCenter);

                    break;

                default:
                    break;
            }
            
        }
        private void crtlViewCars_Click(object sender, EventArgs e) {
            CarViewForm viewCars = new CarViewForm();
            //viewCars.MdiParent = this;
            viewCars.serviceCenter = serviceCenter;
            viewCars.CarsList = GetCarsList();

            viewCars.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            AddCustomer();
        }

        public void AddCustomer() {
            Customer customer = new Customer();

            CustomerForm form = new CustomerForm();
            form.MdiParent = this;
            form.MyCustomer = customer;
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
                //MdiParent = this,

                NewServiceTask = serviceTask,
                 //NewServiceCenter = serviceCenter
             };

            DialogResult result= serviceTaskForm.ShowDialog();

            switch (result) {
                
                case DialogResult.OK:

                    serviceCenter.ServiceTasks.Add(serviceTask);
                    MyJsonHandler.SerializeToJson(serviceCenter);
                   
                    break;
                
                case DialogResult.Cancel:

                    break;
                            
                default:
                    break;
            }

        }

        //private List<string> RefreshServiceTasksList() {


        //    serviceTasks = new List<string>();

        //    serviceTasks.Clear();

        //    foreach (ServiceTask task in serviceCenter.ServiceTasks) {

        //        serviceTasks.Add(string.Format("ID={0}\tCode={1}\tDescription={2}\tPricePerHour={3}", task.ID, task.Code, task.Description, task.PricePerHour));
        //    }

        //    return serviceTasks;
        //}

        private void ctrlViewServiceTask_Click(object sender, EventArgs e) {


            ViewServiceTaskForm viewServiceTask = new ViewServiceTaskForm() {

                MdiParent=this,
                NewServiceCenter=serviceCenter,
                //ServiceTasksList = RefreshServiceTasksList()
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

            if (engineerForm.ShowDialog() == DialogResult.OK) {
                serviceCenter.Engineers.Add(engineer);

                DateTime engineerDate = DateTime.Parse(engineer.HiringDate);
                int month = engineerDate.Month;
                int year = engineerDate.Year;

                MonthlyLedger monthlyLedger = serviceCenter.MonthlyLedgers.Find((x => x.Date.Month == month && x.Date.Year == year));

                if (monthlyLedger == null) {
                    monthlyLedger = new MonthlyLedger();
                    monthlyLedger.Date = engineerDate;
                    serviceCenter.MonthlyLedgers.Add(monthlyLedger);
                }
                monthlyLedger.Expenses += engineer.SalaryPerMonth;
                

                MyJsonHandler.SerializeToJson(serviceCenter);
            }

        }


        private void MdiMainForm_Load(object sender, EventArgs e) {

         

            serviceCenter = MyJsonHandler.DeserializeFromJson();
           
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
            viewForm.CustomersList = GetCustomerList();
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
            viewEngineerForm.serviceCenter = serviceCenter;

            viewEngineerForm.Show();
        }

      
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        


        private List<string> GetEngineersList() {

            List<string> engineersList = new List<string>();

            try {

                if (serviceCenter?.Engineers != null) {

                    foreach (Engineer item in serviceCenter.Engineers) {
                        engineersList.Add(string.Format("ID: {3}, Name: {0}, Surname: {1}, Salary: {2}, Hire Date: {4}", 
                            item.Name, item.Surname, item.SalaryPerMonth, item.ID, item.HiringDate));
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

        private List<string> GetCarsList() {

            List<string> carsList = new List<string>();

            try {

                if (serviceCenter?.Cars != null) {

                    foreach (Car item in serviceCenter.Cars) {
                        carsList.Add(string.Format("ID: {3}, Brand: {0}, Car Registration Plate: {1}, Model: {2}",
                            item.Brand, item.CarRegistrationPlate, item.Model, item.ID));
                    }
                }
                else {
                    MessageBox.Show("No Car Exists!");
                }
            }
            catch (Exception ex) {

                MessageBox.Show("Something wrong happened", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            return carsList;
        }


        private void ctrlAddTransaction_Click(object sender, EventArgs e) {

            Transaction transaction = new Transaction() {


                TransactionLines = new List<TransactionLine>()

            };

            transactionForm = new TransactionForm() {
                // MdiParent = this,

                NewServiceCenter = serviceCenter,
                NewTransaction = transaction
            };

            DialogResult result = transactionForm.ShowDialog();

            switch (result) {

                case DialogResult.OK:

                    serviceCenter.Transactions.Add(transaction);

                    //DateTime transactionDate = transaction.Date;
                    DateTime transactionDate = DateTime.Parse(transaction.Date);
                    int month = transactionDate.Month;
                    int year = transactionDate.Year;

                    MonthlyLedger monthlyLedger = serviceCenter.MonthlyLedgers.Find((x => x.Date.Month == month && x.Date.Year == year));

                    if (monthlyLedger == null) {
                        monthlyLedger = new MonthlyLedger();
                        monthlyLedger.Date = transactionDate;
                        serviceCenter.MonthlyLedgers.Add(monthlyLedger);
                    }
                    monthlyLedger.Income += transaction.TotalPrice;

                    MyJsonHandler.SerializeToJson(serviceCenter);

                    //DateTime transactionDate = DateTime.Parse(transaction.Date);
                    //int month = transactionDate.Month;
                    //int year = transactionDate.Year;

                    //MonthlyLedger monthlyLedger = serviceCenter.MonthlyLedgers.Find(x => x.Date.Month == month && x.Date.Year == year);

                    //if (monthlyLedger == null) {
                    //    monthlyLedger = new MonthlyLedger();
                    //    monthlyLedger.Date = transactionDate;
                    //    serviceCenter.MonthlyLedgers.Add(monthlyLedger);
                    //}

                    //MyJsonHandler.SerializeToJson(serviceCenter);

                    break;

                case DialogResult.Cancel:

                    break;

                default:
                    break;
            }


        }

        private void ctrlMonthlyLedgerView_Click(object sender, EventArgs e) {
            ViewMonlthyLedger();
        }

        private void ViewMonlthyLedger() {
            MonthlyLedgerForm monthlyLedgerForm = new MonthlyLedgerForm();
            monthlyLedgerForm.MonthlyLedgerList = GetMonthlyLedgerList();
            monthlyLedgerForm.MyServiceCenter = serviceCenter;
            monthlyLedgerForm.Show();
        }

        private List<string> GetMonthlyLedgerList() {
            List<string> monthlyLedgerList = new List<string>();

            try {
                if (serviceCenter?.MonthlyLedgers != null) {
                    foreach (MonthlyLedger item in serviceCenter.MonthlyLedgers) {
                        monthlyLedgerList.Add($"Income: {item.Income}, Expenses: {item.Expenses}, " +
                            $"Total Price: {item.Total}");
                    }
                }
                else {
                    MessageBox.Show("Data Does Not Exist!");
                }

            }
            catch (Exception ex) {

                MessageBox.Show("Something wrong happened", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return monthlyLedgerList;
        }

        private void ctrlViewTransaction_Click(object sender, EventArgs e) {


            ViewTransactionForm viewTrans = new ViewTransactionForm() {

                MdiParent = this,
                NewServiceCenter = serviceCenter,
                //ServiceTasksList = RefreshServiceTasksList()
            };

            viewTrans.Show();


        }
    }
}
