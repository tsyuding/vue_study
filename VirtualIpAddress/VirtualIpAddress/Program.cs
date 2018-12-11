using AngleSharp;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace VirtualIpAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new byte[100];
            c = null;
            Task t = Test();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        static async Task Test()
        {
            try
            {
                WebProxy WP = new WebProxy("61.183.233.6", 54896);
                ICredentials jxCredt = new NetworkCredential("proxy_username", "proxy_password");
                WP.Credentials = jxCredt;
                string requestUrl = "http://csinvoice.bsgoal.net.cn/home/about";
                var u = new Uri(requestUrl);
                var webreq = HttpWebRequest.Create(u);
                webreq.Proxy = WP;//将代理赋值给HttpWebRequest的Proxy属性 
                var p = await webreq.GetResponseAsync();



                //HttpHost proxy = new HttpHost("你的代理的IP", 8080, "http");
                var html = p.ResponseUri.ToString();
                using (var reader = new StreamReader(p.GetResponseStream()))
                {
                    string data = await reader.ReadToEndAsync();

                }
                string proxyUri = string.Format("{0}:{1}", "58.53.128.83", "3128");

                NetworkCredential proxyCreds = new NetworkCredential(
                    "xxxx",
                    "xxxx"
                );

                WebProxy proxy = new WebProxy(proxyUri, false)
                {
                    UseDefaultCredentials = false,
                    Credentials = proxyCreds,
                };


                var cookieContainer = new CookieContainer();
                var handler = new HttpClientHandler()
                {
                    Proxy = proxy,
                    PreAuthenticate = true,
                    UseDefaultCredentials = false,
                    CookieContainer = cookieContainer

                };



                var httpClient = new HttpClient(handler);
                //var result =await client.GetAsync(requestUrl);
                string e = string.Empty;
                using (HttpResponseMessage response = await httpClient.GetAsync(requestUrl))
                {
                    e = await response.Content.ReadAsStringAsync();
                }
                //httpClient.h
                //httpClient.DefaultRequestHeaders.Add("X-Forwarded-For", "162.150.10.16");
                //httpClient.
                var Requester = new HttpClientRequester(httpClient);
                var Configuration = AngleSharp.Configuration.Default.WithDefaultLoader(setup =>
                {
                    setup.IsResourceLoadingEnabled = true;
                }, requesters: new[] { Requester }).WithJavaScript().WithCss();
               

                var config = Configuration.Default.WithDefaultLoader();
            }
            catch (Exception ex)
            {

            }


        }
    }
}
