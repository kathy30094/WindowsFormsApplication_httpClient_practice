﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;




namespace WindowsFormsApplication1
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ApiFunctions.PostEmployee((Convert.ToInt32(ID.Text)), name.Text, sex.Text);
            CleanAllText();
        }

        private void search_Click(object sender, EventArgs e)
        {
            Employee theEmployee = new Employee();
            theEmployee = ApiFunctions.SearchEmployee(Convert.ToInt32(ID.Text));
            CleanAllText();
            lableShow.Text = theEmployee.ID + "   " + theEmployee.name + "   " + theEmployee.sex;
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList = ApiFunctions.ShowAllEmployees();
            CleanAllText();
            foreach (var employee in employeeList)
            {
                lableShow.Text += employee.ID + "   " + employee.name + "   " + employee.sex+"\n";
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            ApiFunctions.DeleteEmployee(Convert.ToInt32(ID.Text));
            CleanAllText();
        }

        private void change_Click(object sender, EventArgs e)
        {
            ApiFunctions.PutEmployee((Convert.ToInt32(ID.Text)), name.Text, sex.Text);
            CleanAllText();
        }
        void CleanAllText()
        {
            ID.Text = null;
            name.Text = null;
            sex.Text = null;
            lableShow.Text = null;
        }
        
        


    }
}
