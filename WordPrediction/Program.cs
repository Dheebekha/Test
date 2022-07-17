using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;


namespace WordPrediction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            WordPrediction words = new WordPrediction();
            String wordPredictions = words.getPredictions();
            Console.WriteLine(wordPredictions);
            Console.ReadLine();
        }
    }
    public class WordPrediction
        {
        public String getPredictions()
        {
            String response = "";
            try
            {
                HttpClient client = new HttpClient();
                String AccessToken = "MjAyMi0wNy0xNA==.dmNkZWVwaUBnbWFpbC5jb20=.ZjlhNTVhNzY5MjQ3NGRlMDBmMGNmMTQyZmNhMTFhYTE=";
                String Cookie = "MID=a022a33d-dd50-4f5d-b621-62d10d8c032f; PHPSESSID=ljc6keghljo5ta1hndjtk4vau1";
                String baseUrl = "https://services.lingapps.dk/misc/";
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessToken);
                client.DefaultRequestHeaders.Add("Cookie", Cookie);
                client.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                var wordPredictionResponse = client.GetAsync(baseUrl + "getPredictions?locale=en-GB&text=I%20like%20in").Result;
                var updateResponse = wordPredictionResponse.Content.ReadAsStringAsync().Result.Replace("\n   ", "");
                updateResponse.Replace("\"", "");
                response = updateResponse;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message + "occured while fetching data from Web Service");
            }
            return response;
            
        }
    }

}
