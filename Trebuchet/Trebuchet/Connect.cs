﻿using System;
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
                ////Sleep pour éviter trop d'appels toutes les 3 secondes
                //Thread.Sleep(1500);

                //Création de la requête GET avec les identifiants
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(link);
                request.Method = "GET";
                request.Credentials = new NetworkCredential(username, password);

                //Lecture de la réponse du serveur (en XML)
                reader = new StreamReader(((HttpWebResponse)request.GetResponse()).GetResponseStream());
                answer = reader.ReadToEnd();


            }
            catch (Exception e)
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
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            return life;
        }

        public void Fire(int power, string target)
        {
            try
            {
                Console.WriteLine("\nTir en cours...");
                //Sleep pour éviter les appels trop rapides au serveur
                Thread.Sleep(1500);


                //Création de la requête avec les bons credentials
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://dev18504.service-now.com/api/20557/catapulte/fire?power=" + power + "&target=" + target);
                request.Method = "POST";

                string credentials = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                request.Headers.Add("Authorization", "Basic " + credentials);

                //Récupération de la réponse pour s'assurer que tout s'est bien passé
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("Le " + target + " a été touché général !");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "L'appel au serveur a échoué");
            }
        }

        public void Heal(string target)
        {
            try
            {
                Console.WriteLine("Réparation en cours");
                //Sleep pour éviter d'appeler trop rapidement le serveur 
                Thread.Sleep(1500);


                //Création de la requête avec les credentials
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://dev18504.service-now.com/api/20557/catapulte/target=" + target);
                request.Method = "POST";

                string credentials = Convert.ToBase64String(Encoding.GetEncoding("ISO-8859-1").GetBytes(username + ":" + password));

                request.Headers.Add("Authorization", "Basic " + credentials);

                //Récupération de la réponse pour s'assurer que tout s'est bien passé
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("Catapulte réparée !");
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "L'appel au serveur a échoué");
            }
        }

        public int GetInt(string str)
        {
            //On souhaite récupérer uniquement la valeur des PV dans la réponse en XML du serveur
            //On supprime tout ce qui n'est pas un chiffre dans la réponse 
            Regex regex = new Regex(@"\b\d+\b");
            MatchCollection collection = regex.Matches(str);

            List<int> ints = new List<int>();
            int result;
            foreach (Match match in collection)
            {
                //Cast de la réponse (string) en int
                result = int.Parse(match.Value);
                ints.Add(result);
            }

            //On renvoie le premier nombre trouvé (qui sera nos PV)
            return ints[0];
        }


    }


}
