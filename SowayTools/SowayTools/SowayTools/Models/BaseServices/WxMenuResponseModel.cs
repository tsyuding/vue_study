using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SowayTools.Models.BaseServices
{
    public class WxHttpWebResponseModel
    {

        public string ErrCode { get; set; }
        public string ErrMsg { get; set; }
        public string Access_Token { get; set; }
        public string Expires_In { get; set; }
        public bool IsSeccess
        {
            get
            {
                return string.IsNullOrWhiteSpace(ErrCode);
            }
        }
    }

    public class ButtonItem
    {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 游戏中心
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        public string key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Sub_ButtonItem> sub_button { get; set; }
    }


    public class Sub_ButtonItem {
        /// <summary>
        /// 
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 游戏中心
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        public string key { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> sub_button { get; set; }
    }

    public class Menu
    {
        /// <summary>
        /// 
        /// </summary>
        public List<ButtonItem> button { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public Menu menu { get; set; }
    }

    /////////////////////////////////////////////////////////


}