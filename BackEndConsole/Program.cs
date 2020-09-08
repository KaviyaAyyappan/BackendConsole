using System;
using System.IO;
using System.Net;

namespace BackEndConsole
{
    public class WebRequestGetExample
    {
        public static void Main()
        {
            WebRequest request = WebRequest.Create("https://localhost:44366/api/Speakers/");
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                Console.WriteLine(responseFromServer);
            }
            response.Close();
        }
    }
}
