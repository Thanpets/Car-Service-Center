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

        public void ctrlAddCustomer_Click(object sender, EventArgs e) {

            AddEntity(EntityAddTypes.Customer);

        }
 
        private void crtlAddCar_Click(object sender, EventArgs e) {

            AddEntity(EntityAddTypes.Car);
        }


        private void ctrlAddEngineer_Click(object sender, EventArgs e) {

            AddEntity(EntityAddTypes.Engineer);

        }

        private void ctrlAddServiceTask_Click(object sender, EventArgs e) {

            AddEntity(EntityAddTypes.ServiceTask);

        }

        private void ctrlAddTransaction_Click(object sender, EventArgs e) {

            AddEntity(EntityAddTypes.Transaction);
        }

        private void AddEntity(EntityAddTypes entityType) {
            switch (entityType) {
                case EntityAddTypes.Car:

                    Car car = new Car();

                    CarForm carForm = new CarForm();
                    //form.MdiParent = this;
                    carForm.NewCar = car;
                    DialogResult carResult = carForm.ShowDialog();
                    switch (carResult) {
                        case DialogResult.OK:

                            serviceCenter.Cars.Add(car);
                            MyJsonHandler.SerializeToJson(serviceCenter);

                            break;

                        default:
                            break;
                    }

                    break;
                case EntityAddTypes.Customer:

                    Customer customer = new Customer();

                    CustomerForm custForm = new CustomerForm();
                    //form.MdiParent = this;
                    custForm.MyCustomer = customer;
                    DialogResult custResult = custForm.ShowDialog();


                    switch (custResult) {
                        case DialogResult.OK:

                            serviceCenter.Customers.Add(customer);
                            MyJsonHandler.SerializeToJson(serviceCenter);


                    break;

                        default:
                            break;
                    }

                    break;
                case EntityAddTypes.Engineer:

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


                    break;
                case EntityAddTypes.ServiceTask:

                    ServiceTask serviceTask = new ServiceTask();

                    serviceTaskForm = new ServiceTaskForm() {
                        //MdiParent = this,

                        NewServiceTask = serviceTask,
                        //NewServiceCenter = serviceCenter
                    };

                    DialogResult serviceTaskResult = serviceTaskForm.ShowDialog();

                    switch (serviceTaskResult) {

                        case DialogResult.OK:

                            serviceCenter.ServiceTasks.Add(serviceTask);
                            MyJsonHandler.SerializeToJson(serviceCenter);

                            break;

                        case DialogResult.Cancel:

                            break;

                        default:
                            break;
                    }


                    break;
                case EntityAddTypes.Transaction:

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

                            MonthlyLedger monthlyLedger = serviceCenter.MonthlyLedgers.Find((x => DateTime.Parse(x.Date).Month == month && DateTime.Parse(x.Date).Year == year));

                            if (monthlyLedger == null) {
                                monthlyLedger = new MonthlyLedger();
                                monthlyLedger.Date = Convert.ToDateTime(transactionDate).Date.ToString("dd/MM/yyyy");
                                serviceCenter.MonthlyLedgers.Add(monthlyLedger);
                                foreach (var eng in serviceCenter.Engineers) {
                                    monthlyLedger.Expenses += eng.SalaryPerMonth;

                                }
                            }
                            monthlyLedger.Income += transaction.TotalPrice;


                            MyJsonHandler.SerializeToJson(serviceCenter);

                            break;

                        case DialogResult.Cancel:

                            break;

                        default:
                            break;
                    }


                    break;
                default:
                    break;
            }
        }

        private void ctrlViewCustomer_Click(object sender, EventArgs e){

            ViewEntity(EntityAddTypes.Customer);
        }
       
        private void crtlViewCars_Click(object sender, EventArgs e) {
           
            ViewEntity(EntityAddTypes.Car);
        }

        private void ctrlViewEngineer_Click(object sender, EventArgs e) {
           
            ViewEntity(EntityAddTypes.Engineer);
        }

        private void ctrlViewServiceTask_Click(object sender, EventArgs e) {
            
            ViewEntity(EntityAddTypes.ServiceTask);
        }

        private void ctrlViewTransaction_Click(object sender, EventArgs e) {
            
            ViewEntity(EntityAddTypes.Transaction);
        }

        private void ctrlMonthlyLedgerView_Click(object sender, EventArgs e) {
            
            ViewEntity(EntityAddTypes.MonthlyLadger);
        }

        private void ViewEntity(EntityAddTypes entityType) {
            switch (entityType) {
                case EntityAddTypes.Car:

                    CarViewForm viewCars = new CarViewForm();
                    viewCars.MdiParent = this;
                    viewCars.serviceCenter = serviceCenter;

                    viewCars.Show();

                    break;

                case EntityAddTypes.Customer:

                    CustomerViewForm viewForm = new CustomerViewForm();
                    viewForm.MdiParent = this;
                    viewForm.serviceCenter = serviceCenter;

                    viewForm.Show();

                    break;

                case EntityAddTypes.Engineer:

                    ViewEngineersForm viewEngineerForm = new ViewEngineersForm();
                    viewEngineerForm.MdiParent = this;
                    viewEngineerForm.serviceCenter = serviceCenter;

                    viewEngineerForm.Show();

                    break;

                case EntityAddTypes.ServiceTask:

                    ViewServiceTaskForm viewServiceTask = new ViewServiceTaskForm() {

                        MdiParent = this,
                        NewServiceCenter = serviceCenter,
                    };

                    viewServiceTask.Show();

                    break;

                case EntityAddTypes.Transaction:

                    ViewTransactionForm viewTrans = new ViewTransactionForm() {

                        MdiParent = this,
                        NewServiceCenter = serviceCenter,
                    };

                    viewTrans.Show();

                    break;

                case EntityAddTypes.MonthlyLadger:

                    MonthlyLedgerForm monthlyLedgerForm = new MonthlyLedgerForm();
                    monthlyLedgerForm.MyServiceCenter = serviceCenter;
                    monthlyLedgerForm.MdiParent = this;
                    monthlyLedgerForm.Show();

                    break;

                default:
                    break;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        
    }
}
