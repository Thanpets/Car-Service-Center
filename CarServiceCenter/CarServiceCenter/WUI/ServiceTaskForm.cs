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
    public partial class ServiceTaskForm : Form {

        public ServiceTask NewServiceTask { get; set; }

        public ServiceCenter NewServiceCenter { get; set; }

        

        public ServiceTaskForm() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {

         

            if (!string.IsNullOrWhiteSpace(Convert.ToString(ctrlCode.Text))  || !string.IsNullOrWhiteSpace(Convert.ToString(ctrlDescription.Text))) {

                NewServiceTask.Code = Convert.ToString(ctrlCode.Text);

                NewServiceTask.Description = Convert.ToString(ctrlDescription.Text);

                NewServiceTask.PricePerHour = ctrlPricePerHour.Value;


                //------------------------------------------------------
                // NewServiceCenter.ServiceTasks.Add(NewServiceTask);
                //------------------------------------------------------


                Close();
            }
  
            else {

                MessageBox.Show("Code and Description are required.");
            }

      }


        private void btnCancel_Click(object sender, EventArgs e) {

            Close();
        }

        private void ServiceTaskForm_Load(object sender, EventArgs e) {

        }

        private void ServiceTaskForm_Deactivate(object sender, EventArgs e) {

        }
    }
}
