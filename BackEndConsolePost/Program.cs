using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using Newtonsoft.Json;


namespace BackEndConsolePost
{
    public class Program
    {
        static void Main(String[] args)
        {
            PostJson("https://localhost:44366/api/Speakers", new Speaker
            {
                name = "william smith",
                Bio= "likes to drive cars",
                webSite="www.smith.com"

            });

        }
        private static void PostJson(string uri, Speaker postParameters)
        {
            string postData = JsonConvert.SerializeObject(postParameters);
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.Method = "POST";
            httpWebRequest.ContentLength = bytes.Length;
            httpWebRequest.ContentType = "application/json";
            using (Stream requestStream = httpWebRequest.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Count());
            }
            var httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Console.WriteLine(httpWebResponse);
        }
    }
    public class Speaker
    {
    public string name { get; set; }
    public string Bio { get; set; }
    public string webSite { get; set; }
}

}
