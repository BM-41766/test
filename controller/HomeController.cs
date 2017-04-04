using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Registration.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View("Registration_page");
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Registration_page(string cmd,HttpPostedFileBase file, string firstname, string profilepic, string gender, string email, string address, string country, string Hobbies, string password)
        {
            if (cmd == "Save")
            {
            string Image_url = file.ToString();   
        
        var fileName = Path.GetFileName(file.FileName);  
        var ext = Path.GetExtension(file.FileName); 
          
            string name = Path.GetFileNameWithoutExtension(fileName);  
            string myfile = name + "_" + firstname + ext;  
             
            var path = Path.Combine(Server.MapPath("~/profileimgs"), myfile);  
            Image_url = path;    
            file.SaveAs(path);           
                ServiceReference1.Service1Client sr1 = new ServiceReference1.Service1Client();
                sr1.Registration(firstname, profilepic, email, address, password, gender, country, Hobbies);
            }
            return null;
        }
    }
}
