using System;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
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


        public Connect() { }

        public int GetLifeAsync(string name)
        {
            string link = URL + name;
            try
            {
                Console.WriteLine("Récupération de la vie de " + name);
                Thread.Sleep(1500);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                request.Method = "GET";
                request.Credentials = new NetworkCredential("groupe9", "bur8NeG3");
                string credentials = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                request.Headers.Add("Authorization", "Basic " + credentials);

                reader = new StreamReader(((HttpWebResponse)request.GetResponse()).GetResponseStream());
                answer = reader.ReadToEnd();

                Thread.Sleep(1500);
                
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

        public void Fire(int power, string target)
        {
            try
            {
                Console.WriteLine("Tir en cours...");
                Thread.Sleep(1500);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://dev18504.service-now.com/api/20557/catapulte/attack?power=" + power + "&target=" + target);
                request.Method = "POST";

                string credentials = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                request.Headers.Add("Authorization", "Basic " + credentials);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message + "L'appel au serveur a échoué");
            }        
        }

        public void Heal(string target)
        {
            try
            {
                Console.WriteLine("Réparation en cours");
                Thread.Sleep(1500);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://dev18504.service-now.com/api/20557/catapulte/target=" + target);
                request.Method = "POST";

                string credentials = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                request.Headers.Add("Authorization", "Basic " + credentials);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "L'appel au serveur a échoué");
            }
        }
        
        public int GetInt(string str)
        {
            Regex regex = new Regex(@"\b\d+\b");
            MatchCollection collection = regex.Matches(str);

            List<int> ints = new List<int>();
            int result;
            foreach(Match match in collection)
            {
                result = int.Parse(match.Value);
                ints.Add(result);
            }


            return ints[0];
        }


    }

   
}
