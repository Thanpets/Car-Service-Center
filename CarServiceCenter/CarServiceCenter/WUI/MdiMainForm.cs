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
        private TransactionForm transactionForm = null;

        public MdiMainForm() {
            InitializeComponent();
            MyJsonHandler = new JsonHandler();
        }

        private void MdiMainForm_Load(object sender, EventArgs e) {
            serviceCenter = MyJsonHandler.DeserializeFromJson();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Application.Exit();
        }

        private void ctrlAddCustomer_Click(object sender, EventArgs e) {
            AddCustomer();
        }

        private void crtlAddCar_Click(object sender, EventArgs e) {
            AddNewCar();
        }

        private void ctrlAddEngineer_Click(object sender, EventArgs e) {
            AddEngineer();
        }

        private void ctrlAddServiceTask_Click(object sender, EventArgs e) {
            AddServiceTask();

        }

        private void ctrlAddTransaction_Click(object sender, EventArgs e) {
            AddTransaction();

        }

        private void AddCustomer() {

            Customer customer = new Customer();
            CustomerForm form = new CustomerForm();

            form.MyCustomer = customer;
            DialogResult result = form.ShowDialog();


            switch (result) {
                case DialogResult.OK:

                    serviceCenter.Customers.Add(customer);
                    MyJsonHandler.SerializeToJson(serviceCenter);

                    break;

                default:
                    break;
            }

        }

        private void AddNewCar() {
            Car car = new Car();

            CarForm form = new CarForm();
            form.NewCar = car;
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

        private void AddEngineer() {

            Engineer engineer = new Engineer();

            EngineerForm engineerForm = new EngineerForm();
            engineerForm.MyEngineer = engineer;

            if (engineerForm.ShowDialog() == DialogResult.OK) {
                serviceCenter.Engineers.Add(engineer);

                DateTime engineerDate = DateTime.Parse(engineer.HiringDate);
                int month = engineerDate.Month;
                int year = engineerDate.Year;

                MonthlyLedger monthlyLedger = serviceCenter.MonthlyLedgers.Find((x => DateTime.Parse(x.Date).Month == month && DateTime.Parse(x.Date).Year == year));

                if (monthlyLedger == null) {
                    monthlyLedger = new MonthlyLedger();
                    monthlyLedger.Date = Convert.ToDateTime(engineerDate).Date.ToString("dd/MM/yyyy"); ;
                    serviceCenter.MonthlyLedgers.Add(monthlyLedger);
                    foreach (var eng in serviceCenter.Engineers) {
                        if (DateTime.Parse(eng.HiringDate).Year < engineerDate.Year || (DateTime.Parse(eng.HiringDate).Year == engineerDate.Year && DateTime.Parse(eng.HiringDate).Month < engineerDate.Month)) {
                            monthlyLedger.Expenses += eng.SalaryPerMonth;
                        }
                        else if (DateTime.Parse(eng.HiringDate).Year == engineerDate.Year && DateTime.Parse(eng.HiringDate).Month == engineerDate.Month) {
                            monthlyLedger.Expenses += (eng.SalaryPerMonth * (31 - engineerDate.Day) / 30);
                        }

                    }
                }
                else {
                    monthlyLedger.Expenses += (engineer.SalaryPerMonth * (31 - engineerDate.Day) / 30);
                }

                MyJsonHandler.SerializeToJson(serviceCenter);
            }

        }

        private void AddServiceTask() {
            ServiceTask serviceTask = new ServiceTask();

            serviceTaskForm = new ServiceTaskForm() {

                NewServiceTask = serviceTask,
            };

            DialogResult result = serviceTaskForm.ShowDialog();

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

        private void AddTransaction() {

            Transaction transaction = new Transaction() {


                TransactionLines = new List<TransactionLine>()

            };

            transactionForm = new TransactionForm() {

                NewServiceCenter = serviceCenter,
                NewTransaction = transaction
            };

            DialogResult result = transactionForm.ShowDialog();

            switch (result) {

                case DialogResult.OK:

                    serviceCenter.Transactions.Add(transaction);

                    DateTime transactionDate = DateTime.Parse(transaction.Date);
                    int month = transactionDate.Month;
                    int year = transactionDate.Year;

                    MonthlyLedger monthlyLedger = serviceCenter.MonthlyLedgers.Find((x => DateTime.Parse(x.Date).Month == month && DateTime.Parse(x.Date).Year == year));

                    if (monthlyLedger == null) {
                        monthlyLedger = new MonthlyLedger();
                        monthlyLedger.Date = Convert.ToDateTime(transactionDate).Date.ToString("dd/MM/yyyy");
                        serviceCenter.MonthlyLedgers.Add(monthlyLedger);
                    }
                    monthlyLedger.Income += transaction.TotalPrice;

                    MyJsonHandler.SerializeToJson(serviceCenter);

                    break;

                case DialogResult.Cancel:

                    break;

                default:
                    break;
            }
        }

        private void ctrlViewCustomer_Click(object sender, EventArgs e) {
            ViewCustomers();
        }

        private void crtlViewCars_Click(object sender, EventArgs e) {
            ViewCars();
        }

        private void ctrlViewEngineer_Click(object sender, EventArgs e) {
            ViewEngineers();
        }

        private void ctrlViewServiceTask_Click(object sender, EventArgs e) {
            ViewServiceTasks();

        }

        private void ctrlViewTransaction_Click(object sender, EventArgs e) {
            ViewTransactions();

        }

        private void ctrlMonthlyLedgerView_Click(object sender, EventArgs e) {
            ViewMonlthyLedger();
        }

        private void ViewCustomers() {

            CustomerViewForm viewForm = new CustomerViewForm();
            viewForm.MdiParent = this;
            viewForm.serviceCenter = serviceCenter;

            viewForm.Show();
        }

        private void ViewCars() {
            CarViewForm viewCars = new CarViewForm();
            viewCars.MdiParent = this;
            viewCars.serviceCenter = serviceCenter;

            viewCars.Show();
        }

        private void ViewEngineers() {

            ViewEngineersForm viewEngineerForm = new ViewEngineersForm();
            viewEngineerForm.MdiParent = this;
            viewEngineerForm.serviceCenter = serviceCenter;

            viewEngineerForm.Show();
        }

        private void ViewServiceTasks() {
            ViewServiceTaskForm viewServiceTask = new ViewServiceTaskForm() {

                MdiParent = this,
                NewServiceCenter = serviceCenter,
            };

            viewServiceTask.Show();
        }

        private void ViewTransactions() {
            ViewTransactionForm viewTrans = new ViewTransactionForm() {

                MdiParent = this,
                NewServiceCenter = serviceCenter,
            };

            viewTrans.Show();
        }

        private void ViewMonlthyLedger() {

            MonthlyLedgerForm monthlyLedgerForm = new MonthlyLedgerForm();
            monthlyLedgerForm.MyServiceCenter = serviceCenter;
            monthlyLedgerForm.MdiParent = this;
            monthlyLedgerForm.Show();

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        
    }
}
