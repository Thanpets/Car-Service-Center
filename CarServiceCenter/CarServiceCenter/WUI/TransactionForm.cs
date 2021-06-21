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
    public partial class TransactionForm : Form {

        public ServiceCenter NewServiceCenter { get; set; }

        public Transaction NewTransaction { get; set; }

        private TransactionLinesForm transactionLinesForm = null;

        private TransactionLine transactionLine = null;

        private string checkBoxSelectedItem = null;

        private int indexFromPoint = 0;

        public TransactionForm() {
            InitializeComponent();
        }



        private void ctrlOK_Click(object sender, EventArgs e) {

            if (ctrlCustomers.SelectedItems.Count > 0 && ctrlCars.SelectedItems.Count > 0 && ctrlTransactionLines.CheckedItems.Count > 0) {


                string currentCustomer = Convert.ToString(ctrlCustomers.SelectedIndices[0]);
                string currentCar = Convert.ToString(ctrlCars.SelectedIndices[0]);

                decimal total = 0m;


                //unresolved conflict
                NewTransaction.Date = Convert.ToString(ctrlDate.Value.Date);
                //NewTransaction.Date = Convert.ToDateTime(ctrlDate.Value).Date.ToString("dd/MM/yyyy");

                NewTransaction.CustomerID = Guid.Parse(currentCustomer.Substring(Math.Max(0, currentCustomer.Length - 36)));

                NewTransaction.CarID = Guid.Parse(currentCar.Substring(Math.Max(0, currentCar.Length - 36)));

                // NewTransaction.TransactionLines.Add(ctrlTransactionLines.SelectedItems.);

                foreach (var item in NewTransaction.TransactionLines) {
                    total += item.Price;
                }

                NewTransaction.TotalPrice = total;

                DialogResult = DialogResult.OK;
            }

            else {

                MessageBox.Show("All fields are required.");
            }

        }

        private void ctrlCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;

            Close();
        }

     

        private void TransactionForm_Load(object sender, EventArgs e) {

            ctrlCustomers.Items.Clear();

            ctrlCustomers.View = View.Details;
            ctrlCustomers.Columns.Add("Name", 80);
            ctrlCustomers.Columns.Add("Last Name", 80);
            ctrlCustomers.Columns.Add("Phone", 80);
            ctrlCustomers.Columns.Add("TIN", 80);


            ctrlCars.Items.Clear();

            ctrlCars.View = View.Details;
            ctrlCars.Columns.Add("Brand", 100);
            ctrlCars.Columns.Add("Model", 100);
            ctrlCars.Columns.Add("Registration Plate", 100);


            LoadData();


           
            foreach (var item in NewServiceCenter.ServiceTasks) {

                ctrlTransactionLines.Items.Add(string.Format("{0}\t\t\t{1}", Convert.ToString(item.Description), Convert.ToString(item.ID)));
            }

        }

        private void LoadData() {

            foreach (var item in NewServiceCenter.Cars) {
                string StringWithoutID = string.Format("{0},{1},{2}", item.Brand, item.Model, item.CarRegistrationPlate);
                string[] listParse = StringWithoutID.Split(',').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                ctrlCars.Items.Add(listViewItem);

            }

            foreach (var item in NewServiceCenter.Customers) {
                string StringWithoutID = string.Format("{0},{1},{2},{3}", item.Name, item.Surname, item.Phone, item.TIN);
                string[] listParse = StringWithoutID.Split(',').ToArray();

                ListViewItem listViewItem;
                listViewItem = new ListViewItem(listParse);
                ctrlCustomers.Items.Add(listViewItem);

            }

        }

        private void check(MouseEventArgs e) {

            //    if (ctrlTransactionLines.SelectedItem
            //        [ctrlTransactionLines.IndexFromPoint(e.Location)]  ) {
            indexFromPoint = ctrlTransactionLines.IndexFromPoint(e.Location);
            if (indexFromPoint == -1) {
                MessageBox.Show("Please click on a specific item.");
            }
            else {
                checkBoxSelectedItem = Convert.ToString(ctrlTransactionLines.SelectedItem);
                //if on click is checked
                if (ctrlTransactionLines.GetItemCheckState(indexFromPoint) == CheckState.Unchecked) {
                    //-----------------------------------------------------------------------------------
                    //if on click is unchecked
                    ServiceTask task = NewServiceCenter.ServiceTasks.Find(x => x.ID == Guid.Parse(checkBoxSelectedItem.Substring(Math.Max(0, checkBoxSelectedItem.Length - 36))));
                    transactionLine = new TransactionLine() {
                        ServiceTaskID = task.ID
                    };
                    transactionLinesForm = new TransactionLinesForm() {
                        
                        NewNewServiceCenter = NewServiceCenter,
                        NewTransactionLine = transactionLine
                    };
                    DialogResult result = transactionLinesForm.ShowDialog();
                    switch (result) {
                        case DialogResult.OK:
                            //if (ctrlTransactionLines.GetItemCheckState(e.Index) == CheckState.Checked) {
                            //mark it as checked
                            ctrlTransactionLines.SetItemChecked(indexFromPoint, true);
                            //Transaction trans = new Transaction();
                            transactionLine.ServiceTaskID = task.ID;
                            transactionLine.Price = transactionLine.Hours * task.PricePerHour;
                            //NewTransaction.TransactionLines.Add(transactionLine);
                            //NewServiceCenter.Transactions.Add(NewTransaction);
                            NewTransaction.TransactionLines.Add(transactionLine);
                            //}
                            //else {
                            //    ctrlTransactionLines.SetItemChecked(e.Index, true);
                            //}
                            break;
                        case DialogResult.Cancel:
                            //uncheck it
                            ctrlTransactionLines.SetItemChecked(indexFromPoint, false);
                            //NewTransaction.TransactionLines.Remove(transactionLine);
                            NewTransaction.TransactionLines.RemoveAll(x => x.ServiceTaskID == Guid.Parse(checkBoxSelectedItem.Substring(Math.Max(0, checkBoxSelectedItem.Length - 36))));
                            //ctrlTransactionLines.IndexFromPoint(e.Location);
                            break;
                        default:
                            break;
                    }
                    //------------------------------------------------------------------------------------
                    //unckeck it
                }
                //}
                else {//not checked
                    ctrlTransactionLines.SetItemChecked(indexFromPoint, false);
                    //remove it from transaction lines
                    NewTransaction.TransactionLines.RemoveAll(x => x.ServiceTaskID == Guid.Parse(checkBoxSelectedItem.Substring(Math.Max(0, checkBoxSelectedItem.Length - 36))));
                }
            }
        }


        private void ctrlTransactionLines_MouseClick(object sender, MouseEventArgs e) {

            for (int i = 0; i < ctrlTransactionLines.Items.Count; i++) {


                if (ctrlTransactionLines.GetItemRectangle(i).Contains(ctrlTransactionLines.PointToClient(MousePosition))) {
                    switch (ctrlTransactionLines.GetItemCheckState(i)) {
                        case CheckState.Checked:
                         string   checkBoxSelectedItem1 = Convert.ToString(ctrlTransactionLines.Items[i]);
                            /*
                            ctrlTransactionLines.SetItemCheckState(i, CheckState.Unchecked);
                            */
                            //ctrlTransactionLines.SetItemCheckState(i, CheckState.Unchecked);
                            //ctrlTransactionLines.SetItemChecked(indexFromPoint, false);
                            //remove it from transaction lines
                         
                        /*    
                            NewTransaction.TransactionLines.RemoveAll(x => x.ServiceTaskID == Guid.Parse(checkBoxSelectedItem.Substring(Math.Max(0, checkBoxSelectedItem.Length - 36))));
                        */
                            //------------------------------------------------------------------------------------

                            ServiceTask task = NewServiceCenter.ServiceTasks.Find(x => x.ID == Guid.Parse(checkBoxSelectedItem1.Substring(Math.Max(0, checkBoxSelectedItem1.Length - 36))));


                            string tmp = string.Format("{0}\t\t{1} hours x {2} Euros per hour\t\t\t\t{3}", task.Description, transactionLine.Hours, task.PricePerHour, task.ID);


                            ctrlTransactionLines.Items[i] = tmp;


                            NewTransaction.TransactionLines.RemoveAll(x => x.ServiceTaskID == Guid.Parse(checkBoxSelectedItem1.Substring(Math.Max(0, checkBoxSelectedItem1.Length - 36))));

                            ctrlTransactionLines.SetItemCheckState(i, CheckState.Unchecked);

                            //----------------------------------------------------------------------------------

                            break;
                        case CheckState.Indeterminate:
                        case CheckState.Unchecked:
                            ctrlTransactionLines.SetItemCheckState(i, CheckState.Checked);

                            checkBoxSelectedItem = Convert.ToString(ctrlTransactionLines.Items[i]);

                            //if it is not checked before clicking on it
                            //----------------------------------------------------------------------------------------------------------------------------------------------------

                            //-------------------------------------------------------------------------------------------------------------
                            //if on click is unchecked
                            ServiceTask task1 = NewServiceCenter.ServiceTasks.Find(x => x.ID == Guid.Parse(checkBoxSelectedItem.Substring(Math.Max(0, checkBoxSelectedItem.Length - 36))));
                            transactionLine = new TransactionLine() {
                                ServiceTaskID = task1.ID
                            };
                            transactionLinesForm = new TransactionLinesForm() {
                                // MdiParent = this,
                                NewNewServiceCenter = NewServiceCenter,
                                NewTransactionLine = transactionLine
                            };
                            DialogResult result = transactionLinesForm.ShowDialog();
                            switch (result) {
                                case DialogResult.OK:
                                    //if (ctrlTransactionLines.GetItemCheckState(e.Index) == CheckState.Checked) {
                                    //mark it as checked
                                    //ctrlTransactionLines.SetItemChecked(indexFromPoint, true);
                                    //Transaction trans = new Transaction();

                                    //transactionLine.ServiceTaskID = task.ID;

                                    transactionLine.Price = transactionLine.Hours * task1.PricePerHour;
                                    //NewTransaction.TransactionLines.Add(transactionLine);
                                    //NewServiceCenter.Transactions.Add(NewTransaction);
                                    NewTransaction.TransactionLines.Add(transactionLine);


                                    //------------------------------------------------------------------------------------
                                    string tmp1 = string.Format("{0}\t\t{1} hours x {2} Euros per hour\t\t\t\t{3}", task1.Description, transactionLine.Hours, task1.PricePerHour, task1.ID);


                                    ctrlTransactionLines.Items[i] = tmp1;
                                    //----------------------------------------------------------------------------------



                                    //}
                                    //else {
                                    //    ctrlTransactionLines.SetItemChecked(e.Index, true);
                                    //}
                                    break;
                                case DialogResult.Cancel:
                                    //uncheck it
                                    //ctrlTransactionLines.SetItemChecked(indexFromPoint, false);
                                    /*
                                                                        ctrlTransactionLines.SetItemCheckState(i, CheckState.Unchecked);
                                    */
                                    //NewTransaction.TransactionLines.Remove(transactionLine);

                                    /*
                                    NewTransaction.TransactionLines.RemoveAll(x => x.ServiceTaskID == Guid.Parse(checkBoxSelectedItem.Substring(Math.Max(0, checkBoxSelectedItem.Length - 36))));
                                    */
                                    //ctrlTransactionLines.IndexFromPoint(e.Location);
                                  string  checkBoxSelectedItem2 = Convert.ToString(ctrlTransactionLines.Items[i]);

                                    //------------------------------------------------------------------------------------
                                    ServiceTask task2 = NewServiceCenter.ServiceTasks.Find(x => x.ID == Guid.Parse(checkBoxSelectedItem2.Substring(Math.Max(0, checkBoxSelectedItem2.Length - 36))));


                                    string tmp2 = string.Format("{0}\t\t{1} hours x {2} Euros per hour\t\t\t\t{3}", task2.Description, transactionLine.Hours, task2.PricePerHour, task2.ID);


                                    ctrlTransactionLines.Items[i] = tmp2;


                                    NewTransaction.TransactionLines.RemoveAll(x => x.ServiceTaskID == Guid.Parse(checkBoxSelectedItem2.Substring(Math.Max(0, checkBoxSelectedItem2.Length - 36))));

                                    ctrlTransactionLines.SetItemCheckState(i, CheckState.Unchecked);

                                    //----------------------------------------------------------------------------------


                                    break;
                                default:
                                    break;
                            }
                            //------------------------------------------------------------------------------------
                            //unckeck it



                            //-------------------------------------------------------------------------------------------------------------------------------------------------------
                            break;
                    }

                }
                //break;
            }

        }

    
    }
}
