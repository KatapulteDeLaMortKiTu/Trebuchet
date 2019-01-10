using System;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Trebuchet
{
    class Connect
    {
        private const string URL = "https://dev18504.service-now.com/api/20557/catapulte/getlife2?target=";
        private const string username = "groupe9";
        private const string password = "bur8NeG3";
        private string answer;
        private StreamReader reader;

        public int GetLifeAsync(string name)
        {
            string link = URL + name;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                request.Method = "GET";
                request.Credentials = new NetworkCredential("groupe9", "bur8NeG3");
                string credentials = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                request.Headers.Add("Authorization", "Basic " + credentials);

                reader = new StreamReader(((HttpWebResponse)request.GetResponse()).GetResponseStream());
                answer = reader.ReadToEnd();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "L'appel au serveur a échoué");
            }
            finally
            {
                reader.Close();
            }

            int life = default(int);

            try
            {
                life = GetInt(answer);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            return life;
        }

        
        public int GetInt(string str)
        {
            MatchCollection collection = Regex.Matches(str, @"\b\d+\b");

            List<int> ints = new List<int>();
            int result;
            foreach(Match match in collection)
            {
                result = int.Parse(match.Value);
                ints.Add(result);
            }

            result = 0;

            for(int i = 0; i < ints.Count; i++)
            {
                result += ints[i] * (ints.Count - i);
            }

            return result;
        }
    }
}
