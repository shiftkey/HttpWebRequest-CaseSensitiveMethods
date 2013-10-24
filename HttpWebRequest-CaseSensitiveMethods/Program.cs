using System;
using System.Net;

namespace HttpWebRequest_CaseSensitiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = WebRequest.Create("https://api.github.com/user") as HttpWebRequest;
            post.Method = "Post";
            try
            {
                post.GetResponse();
            }
            catch (WebException ex)
            {
                var httpResponse = ex.Response as HttpWebResponse;
                if (httpResponse.StatusCode != HttpStatusCode.Unauthorized)
                {
                    throw;
                }
                else
                {
                    Console.WriteLine("The code fails as expected");
                }
            }

            var patch = WebRequest.Create("https://api.github.com/user") as HttpWebRequest;
            patch.Method = "Patch";
            try
            {
                patch.GetResponse();
            }
            catch (WebException ex)
            {
                var httpResponse = ex.Response as HttpWebResponse;
                if (httpResponse.StatusCode != HttpStatusCode.Unauthorized)
                {
                    throw;
                }
                else
                {
                    Console.WriteLine("The code fails as expected");
                }
            }
        }
    }
}
