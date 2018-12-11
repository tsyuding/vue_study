using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SowayTools.Models.BaseServices
{

    public static class WxApiRequestUrl
    {
        public const string APPID = "wx68eb2ed800cece5a";
        public const string APPSECRET = "9ddb88720d02c2cdd64a022d28db81d9";
        public static string GetAccessTokenUrl
        {
            get
            {
                return "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=" + APPID + "&secret=" + APPSECRET; ;
            }
        }
        public static string GetCurrentSelfMenuInfoUrl
        {
            get
            {
                return "https://api.weixin.qq.com/cgi-bin/menu/get";
            }

        }

        public static string SaveCurrentSelfMenuInfoUrl
        {
            get
            {
                return "https://api.weixin.qq.com/cgi-bin/menu/create";

            }

        }
    }
}