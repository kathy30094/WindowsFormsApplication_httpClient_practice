using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

public class Employee
{
    public int ID { get; set; }
    public string name { get; set; }
    public string sex { get; set; }
}
class ApiFunctions
{
    static string apiServerUrl = "http://localhost.fiddler:25197/api/employee/";

    public static void DeleteEmployee(int id)  //使用deleteAsync
    {
        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("authorization", "token {api token}");
            HttpResponseMessage response = client.DeleteAsync(apiServerUrl + id).Result;
        }
    }  //end__DeleteEmployee

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
            HttpResponseMessage response = client.PostAsync(apiServerUrl, postEmployeeContest).Result;
        }
    }   //end__PostEmployee

    public static async Task<List<Employee>> ShowAllEmployees()
    {
        //get方法
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(apiServerUrl);  ///////host中加入了 .fiddler，供Fiddler抓取封包
        response.EnsureSuccessStatusCode(); //如果回應為false會回傳錯誤
        string responseBody = await response.Content.ReadAsStringAsync();

        List<Employee> EmployeeList = new List<Employee>();
        EmployeeList = JsonConvert.DeserializeObject<List<Employee>>(responseBody);  //將json轉換成Obj list
        return EmployeeList;
    }//show出所有的employee  //end__ShowAllEmployeesGET

    public static async Task<Employee> SearchEmployee(int id)
    {
        //get方法
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(apiServerUrl + id);
        response.EnsureSuccessStatusCode(); //如果回應為false會回傳錯誤
        string responseBody = await response.Content.ReadAsStringAsync();

        Employee employee = new Employee();
        employee = JsonConvert.DeserializeObject<Employee>(responseBody);  //將json轉換成Obj
        return employee;
    }//查詢Employee by id  //end__SearchEmployee

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
    } //修改Employee  //end__PutEmployee
}



