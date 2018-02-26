using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.IO;
using Newtonsoft.Json;




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
            ApiFunctions.SearchEmployee(Convert.ToInt32(ID.Text));
        }

        private void showAll_Click(object sender, EventArgs e)
        {

            ApiFunctions.ShowAllEmployees();
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
        }
        
        


    }
}
