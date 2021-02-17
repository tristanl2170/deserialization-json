using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using APIproject.Models.User;
using System.IO;
using System.Net;
using Newtonsoft.Json;


namespace APIproject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            

            WebRequest request = WebRequest.Create("https://jsonplaceholder.typicode.com/users");
            request.Credentials = CredentialCache.DefaultCredentials;

            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                // Read the content
                string responseFromServer = reader.ReadToEnd();
                //Console.WriteLine(responseFromServer);
                
                
                List<Root> roots = JsonConvert.DeserializeObject<List<Root>>(responseFromServer);

                dataStream.Dispose();

                reader.Dispose();

                response.Close();


                return View(roots);
                
            }


        } //End of Index Method


    }
    
}
