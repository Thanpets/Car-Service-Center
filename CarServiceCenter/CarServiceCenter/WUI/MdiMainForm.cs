﻿using CarServiceCenter.Impl;
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


        public ServiceCenter serviceCenter = null;

        public MdiMainForm() {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            Application.Exit();
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

                    CarService.Customers.Add(customer);

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

        private void ctrlViewServiceTask_Click(object sender, EventArgs e) {

        }
    }
}
