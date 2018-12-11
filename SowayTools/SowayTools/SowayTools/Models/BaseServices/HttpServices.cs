using System;
using System.Collections.Generic;
using System.Web;
using System.Net;
using System.IO;
using System.Text;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;

namespace SowayTools.Models.BaseServices
{
    /// <summary>
    /// http连接基础类，负责底层的http通信
    /// </summary>
    public class HttpServices<T>
    {
        public static T Get(string url)
        {

            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0)";
            //发送请求并获取相应回应数据
            request.AutomaticDecompression = DecompressionMethods.GZip;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream responseStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(responseStream, Encoding.UTF8);
            //返回结果网页（html）代码
            string content = sr.ReadToEnd();
            var data =(T)Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
            return data;
      
        }
        public static T Post(string url,string  param )
        {


            byte[] data = Encoding.UTF8.GetBytes(param);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0)";
            request.AutomaticDecompression = DecompressionMethods.GZip;
            request.ContentLength = data.Length;
            Stream newStream = request.GetRequestStream();

            // Send the data.
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            //发送请求并获取相应回应数据
           
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream responseStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(responseStream, Encoding.UTF8);
            //返回结果网页（html）代码
            string content = sr.ReadToEnd();
            var result = (T)Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
            return result;
        }
        public static T Post(string url)
        {
            
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded; charset=UTF-8";

            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0; Trident/4.0)";
            request.AutomaticDecompression = DecompressionMethods.GZip;

            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream responseStream = response.GetResponseStream();
            StreamReader sr = new StreamReader(responseStream, Encoding.UTF8);
            //返回结果网页（html）代码
            string content = sr.ReadToEnd();
            var result = (T)Newtonsoft.Json.JsonConvert.DeserializeObject<T>(content);
            return result;
        }
    }
}