using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;

namespace Registration_form_service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
      public void Registration(string firstname, string profilepic, string email, string gender, string address, string country,string hobbies, string password)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-GGK19TE\\SQLEXPRESS;Initial Catalog=Registration_form;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "insert into Registration(firstname,profilepic,email,gender,address,country,hobbies,password)values('" + firstname + "','" + profilepic + "','" + email + "','" + gender + "','" + address + "','"+country+"','"+hobbies+"','" + password + "')";
            cmd.ExecuteNonQuery();
           
        }
    }
}
