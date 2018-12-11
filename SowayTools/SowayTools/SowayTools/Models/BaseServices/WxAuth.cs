using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SowayTools.Models.BaseServices
{
    public class WxAuth
    {
        public const string APPID = "wx68eb2ed800cece5a";
        public const string APPSECRET = "9ddb88720d02c2cdd64a022d28db81d9";
        public WxHttpWebResponseModel GetAccessToken()
        {
            string url = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + APPID + "&secret=" + APPSECRET;
            var token = HttpServices<WxHttpWebResponseModel>.Get(url);
            //var html = Get(url);
            //string a = string.Format("LoginName={0}&password={1}&loginType={2}&tokentype={3}", "15170054013", "123456", "0","1");
            //var postdata = HttpServices<Root>.Post("http://api.sowaynet.com/api/account/login", a );
            return token;
        }

        /// <summary>
        /// 获取微信公众号菜单
        /// </summary>
        /// <returns></returns>       
        public FuncResult<Root> GetCurrentSelfMenu()
        {
            var result = GetAccessToken();
            if (!result.IsSeccess)
            {
                return new FuncResult<Root>() { IsSuccess = false, Message = result.ErrMsg };
            }
            string url = string.Format(WxApiRequestUrl.GetCurrentSelfMenuInfoUrl + "?ACCESS_TOKEN={0}", result.Access_Token);
            var data = HttpServices<Root>.Post(url);
            return new FuncResult<Root>() { IsSuccess = true, Data = data };
        }

        public FuncResult SaveCurrentSelfMenuInfoUrl(string param)
        {
            
            var result = GetAccessToken();
            if (!result.IsSeccess)
            {
                return new FuncResult() { IsSuccess = false, Message = result.ErrMsg };
            }
            string url = string.Format(WxApiRequestUrl.SaveCurrentSelfMenuInfoUrl + "?ACCESS_TOKEN={0}", result.Access_Token);
            var data = HttpServices<WeChatResult>.Post(url, param);
            return new FuncResult() { Data=data.ErrCode,Message=data.ErrMsg};
        }

        public class WeChatResult {
            public string ErrCode { get; set; }
            public string ErrMsg { get; set; }
        }
    }
}