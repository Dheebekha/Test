using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CustomDictionary
{
    public class WordPrediction
    {
        public String[] getPredictions(string inputText,string language)
        {
            String[] response = Array.Empty<string>();
            try
            {
                string locale = "en-GB";
                if (!string.IsNullOrWhiteSpace(language))
                {
                    locale = language;
                }
                
                string text = "I%20like%20" + inputText;
                HttpClient client = new HttpClient();
                String AccessToken = "MjAyMi0wNy0xNA==.dmNkZWVwaUBnbWFpbC5jb20=.ZjlhNTVhNzY5MjQ3NGRlMDBmMGNmMTQyZmNhMTFhYTE=";
                String Cookie = "MID=a022a33d-dd50-4f5d-b621-62d10d8c032f; PHPSESSID=ljc6keghljo5ta1hndjtk4vau1";
                String baseUrl = "https://services.lingapps.dk/misc/";
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AccessToken);
                client.DefaultRequestHeaders.Add("Cookie", Cookie);
                client.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
                client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
                //var wordPredictionResponse = client.GetAsync(baseUrl + "getPredictions?locale=en-GB&text=I%20like%20in").Result;
                var wordPredictionResponse = client.GetAsync(baseUrl + "getPredictions?locale=" + locale + "&text=" + text).Result;
                var updateResponse = wordPredictionResponse.Content.ReadAsStringAsync().Result.Replace("\n   ", "");
                updateResponse = updateResponse.Replace("\"", "");
                updateResponse = updateResponse.Replace("[", "");
                updateResponse = updateResponse.Replace("]", "");
                updateResponse = updateResponse.Replace("\n", "");
                string[] updateResponsearray = updateResponse.Split(',');
                response = updateResponsearray;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message + "occured while fetching data from Web Service");
            }
            return response;

        }
        
    }
}
