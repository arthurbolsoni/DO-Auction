using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DO_Login.Services
{
    public class WebRequestService
    {
        public static CookieCollection Cookies = new CookieCollection();

        public static async Task<string> PostRequestAsync(string URL, string Post)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:61.0) Gecko/20100101 Firefox/61.0";
            request.CookieContainer = new CookieContainer();

            foreach (Cookie entry in Cookies)
            {
                request.CookieContainer.Add(entry);
            }

            request.AllowAutoRedirect = false;
            // Wenn wir request sagen, das wir KEINEN proxy haben, sucht er keinen und die Anfrage geht um einiges schneller
            request.Proxy = null;

            // Post-Daten definieren und abschicken
            string PostData = Post;
            byte[] byteArray = Encoding.Default.GetBytes(PostData);
            request.ContentLength = byteArray.Length;
            Stream DataStream = await request.GetRequestStreamAsync();
            DataStream.Write(byteArray, 0, byteArray.Length);
            DataStream.Close();

            // Rückgabe holen
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            DataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(DataStream);
            string ServerResponse = reader.ReadToEnd();
            reader.Close();
            DataStream.Close();

            foreach (Cookie cook in response.Cookies)
            {
                //MessageBox.Show(Convert.ToString(cook));
                Cookies.Add(cook);
            }

            response.Close();
            return ServerResponse;
        }

        public static String GetRequestAsync(string URL)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:61.0) Gecko/20100101 Firefox/61.0";
            request.CookieContainer = new CookieContainer();

            foreach (Cookie entry in Cookies)
            {
                request.CookieContainer.Add(entry);
            }

            Stream DataStream = default(Stream);
            // Rückgabe holen
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            DataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(DataStream);
            string ServerResponse = reader.ReadToEnd();

            foreach (Cookie cook in response.Cookies)
            {
                Cookies.Add(cook);
            }

            reader.Close();
            DataStream.Close();
            response.Close();

            return ServerResponse;
        }
    }
}
