using MVCGetPost.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVCGetPost.Controllers
{
    public class SpeakerController : Controller
    {
       
        // GET: Speaker
        [HttpGet]
        public ActionResult Get()
        {
            WebRequest request = WebRequest.Create("https://localhost:44366/api/Speakers/");
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            using(Stream dataStream= response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                return View(((HttpWebResponse)response).StatusDescription,responseFromServer);
                             

            }
           
            
        }
    }
}