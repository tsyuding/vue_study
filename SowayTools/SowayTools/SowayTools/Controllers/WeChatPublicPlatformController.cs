using Newtonsoft.Json;
using SowayTools.Models.BaseServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SowayTools.Controllers
{
    public class WeChatPublicPlatformController : Controller
    {
        // GET: WeChatPublicPlatform
        [HttpGet]
        public ActionResult Index()
        {
          //  WxAuth wxauth = new WxAuth();
           //var token= wxauth.GetAccessToken();
            return View();
        }
        [HttpGet]
        public ActionResult MenuEdit()
        {
            return View();
        }
        public JsonResult Update(WxButtonArray body)
        {

            var str = JsonConvert.SerializeObject(body);
            WxAuth wxauth = new WxAuth();
            var data = wxauth.SaveCurrentSelfMenuInfoUrl(str);
            return new JsonResult() { Data = new { IsSuccess = data.IsSuccess, Message = data.Message } };
        }
       

        [HttpPost]
        public JsonResult MenuEdit(FormatException form)
        {
            WxAuth wxauth = new WxAuth();
            var data = wxauth.GetCurrentSelfMenu();
            return new JsonResult() { Data=data};
        }

        public JsonResult GetMPMenu()
        {
            return null;
        }




        public class Sub_buttonItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string type { get; set; }
            /// <summary>
            /// 扫码带提示
            /// </summary>
            public string name { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string key { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<string> sub_button { get; set; }
        }

        public class ButtonItem
        {
            /// <summary>
            /// 扫码
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url { get; set; }
            public string key { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<Sub_buttonItem> sub_button { get; set; }
        }

        public class WxButtonArray
        {
            /// <summary>
            /// 
            /// </summary>
            public List<ButtonItem> button { get; set; }
        }



    }
}