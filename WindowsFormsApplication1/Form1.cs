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
    public class Employee
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
    }
    
    public partial class Form1 : Form
    {
        public static List<Employee> employees = new List<Employee>();
        public static Employee employee = new Employee();

        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            PostEmployee((Convert.ToInt32(ID.Text)), name.Text, sex.Text);
            ID.Text = null;
            name.Text = null;
            sex.Text = null;
        }  // end add_Click//////////////////////////////////////////////

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchEmployeeGET.searchEmployee(Convert.ToInt32(ID.Text));
        }

        private void showAll_Click(object sender, EventArgs e)
        {
           
            ShowAllEmployeesGET.showallEmployees();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            DeleteEmployee(Convert.ToInt32(ID.Text));
            ID.Text = null;
            name.Text = null;
            sex.Text = null;

        }

        private void change_Click(object sender, EventArgs e)
        {
            PutEmployee((Convert.ToInt32(ID.Text)), name.Text, sex.Text);
            ID.Text = null;
            name.Text = null;
            sex.Text = null;
        }
        static string apiServerUrl = "http://localhost.fiddler:25197/api/employee/";

        //-------------------------方法
        public static void DeleteEmployee(int id)  //使用deleteAsync
        {
            using (HttpClient client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Add("authorization", "token {api token}");
                HttpResponseMessage response = client.DeleteAsync(apiServerUrl+id).Result;
            }
        }

        public static void PostEmployee(int id, string name, string sex)  //使用postAsync
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("authorization", "token {api token}");    //新增標題，也可以不用
                Employee newEmployee = new Employee() { ID = id, name = name, sex = sex };
                string json = JsonConvert.SerializeObject(newEmployee);
                //指定格式
                HttpContent postEmployeeContest = new StringContent(json, Encoding.UTF8, "application/json");
                //發出post並取得結果
                HttpResponseMessage response = client.PostAsync("http://localhost.fiddler:25197/api/employee", postEmployeeContest).Result;
            }

        } 

        public class ShowAllEmployeesGET
        {
            public static List<Employee> deEployees = new List<Employee>();
            public  static async Task<List<Employee>> showallEmployees()
            {
                //get方法
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(apiServerUrl);  ///////host中加入了 .fiddler
                response.EnsureSuccessStatusCode(); //如果回應為false會回傳錯誤
                string responseBody = await response.Content.ReadAsStringAsync();
                return ReadJsnCollectionsToObjectList(responseBody);
            }
            private static List<Employee> ReadJsnCollectionsToObjectList(string jsonString)
            {
                List<Employee> deEmployees = new List<Employee>();
                deEmployees = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
                return deEmployees;
            }
        }//show出所有的employee

        //public class Test_ShowAllEmployeesGET  //需嘗試解決async await 回傳問題
        //{
        //    public static List<Employee> deEployees = new List<Employee>();
        //    public static async Task<List<Employee>> showallEmployees()
        //    {
        //        //get方法
        //        HttpClient client = new HttpClient();
        //        HttpResponseMessage response = await client.GetAsync(apiServerUrl);  ///////host中加入了 .
        //        response.EnsureSuccessStatusCode(); //如果回應為false會回傳錯誤
        //        string responseBody = await response.Content.ReadAsStringAsync();
        //        return ReadJsnCollectionsToObjectList(responseBody);
        //    }
        //    private static List<Employee> ReadJsnCollectionsToObjectList(string jsonString)
        //    {
        //        List<Employee> deEmployees = new List<Employee>();
        //        deEmployees = JsonConvert.DeserializeObject<List<Employee>>(jsonString);
        //        return deEmployees;
        //    }
        //}//show出所有的employee

        public class SearchEmployeeGET
        {

            public static  async Task<Employee> searchEmployee(int id)
            {
                //get方法
                HttpClient client = new HttpClient();
                HttpResponseMessage response = await client.GetAsync(apiServerUrl + id);
                response.EnsureSuccessStatusCode(); //如果回應為false會回傳錯誤
                string responseBody = await response.Content.ReadAsStringAsync();
                Employee employee = ReadJsnToObject(responseBody);
                ///還需指定給employee object
                return employee;
            }
            private static Employee ReadJsnToObject(string jsonString)//反序列化 json字段為Object
            {
                Employee deEmployee = new Employee();
                deEmployee = JsonConvert.DeserializeObject<Employee>(jsonString);
                return deEmployee;
            }
        }//查詢

        public static void PutEmployee(int id, string name, string sex)  
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("authorization", "token {api token}");    //新增標題，也可以不用
                Employee newEmployee = new Employee() { ID = id, name = name, sex = sex };
                string json = JsonConvert.SerializeObject(newEmployee);
                //指定格式
                HttpContent postEmployeeContest = new StringContent(json, Encoding.UTF8, "application/json");
                //發出post並取得結果
                HttpResponseMessage response = client.PutAsync(apiServerUrl + id, postEmployeeContest).Result;
            }

        } //修改


    }
}
