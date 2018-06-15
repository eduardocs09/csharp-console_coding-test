using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace csharp_console
{
    public static class ThalmicLabsSoftwareEngineerBackend
    {
        public static string[] getMovieTitles(string substr)
        {
            List<string> movieTitles = new List<string>();
            var url = "https://jsonmock.hackerrank.com/api/movies/search/?Title=substr";
            var pagedUrl = "https://jsonmock.hackerrank.com/api/movies/search/?Title=substr&page=pageNumber";

            dynamic firstResponse;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url.Replace("substr", substr));
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                firstResponse = JObject.Parse(reader.ReadToEnd());
                
            }

            int pages = firstResponse.total_pages;
            for (int index = 1; index <= pages; index++)
            {
                dynamic titlesResponse;
                HttpWebRequest moviesRequest = (HttpWebRequest)WebRequest.Create(pagedUrl.Replace("substr", substr).Replace("pageNumber", index.ToString()));
                using (HttpWebResponse moviesResponse = (HttpWebResponse)moviesRequest.GetResponse())
                using (Stream moviesStream = moviesResponse.GetResponseStream())
                using (StreamReader moviesReader = new StreamReader(moviesStream))
                {
                    titlesResponse = JObject.Parse(moviesReader.ReadToEnd());
                }

                foreach (var movie in titlesResponse.data)
                {
                    movieTitles.Add((string)movie.Title);
                }
            }

            movieTitles.Sort();
            return movieTitles.ToArray();
        }
    }
}
