using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.IO;

namespace Trebuchet
{
    class Connect
    {
        private const string URL = "https://dev18504.service-now.com/api/20557/catapulte/getlife2?target=";
        

        static public int GetLifeAsync(string name)
        {
            string link = URL + name;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
            request.Method = "GET";
            request.Credentials = new NetworkCredential("groupe9", "bur8NeG3");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream reception = response.GetResponseStream();
            StreamReader reader = new StreamReader(reception, Encoding.UTF8);
            int life = 0;


            //string resultString = reader.ReadToEnd().Split(' ');
            string test = reader.ReadToEnd();
            //int life = Convert.ToInt32(reader.ReadToEnd());
            Console.WriteLine(test);



            response.Close();
            reader.Close();


            //HttpClient client = new HttpClient
            //{
            //    BaseAddress = new Uri(request)
            //};

            //var values = new Dictionary<string, string> {
            //    { "Id", "groupe9" },
            //    {"password", "bur8NeG3"}
            //};
            //var content = new FormUrlEncodedContent(values);


            //var answer = client.PostAsync(request, content);
            //int life = Convert.ToInt32(client.GetStringAsync(client.BaseAddress).Result);

            return life;
        }

        

    }
}
