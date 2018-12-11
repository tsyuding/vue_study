using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SowayTools
{
    public class FuncResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }

    }
    public class FuncResult<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

    }
}