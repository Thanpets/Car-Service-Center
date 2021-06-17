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
    public partial class ViewServiceTaskForm : Form {


        public List<string> ServiceTasksList { get; set; }


        public ViewServiceTaskForm() {
            InitializeComponent();
        }

        private void ViewServiceTaskForm_Load(object sender, EventArgs e) {
            RefreshView();

        }

        private void RefreshView() {
            ctrlDisplayServiceTasks.Items.Clear();

            foreach (var item in ServiceTasksList) {

                ctrlDisplayServiceTasks.Items.Add(item);

            }
        }

        private void ViewServiceTaskForm_Deactivate(object sender, EventArgs e) {
            RefreshView();

        }

        private void ViewServiceTaskForm_Activated(object sender, EventArgs e) {
            RefreshView();
        }
    }
}
