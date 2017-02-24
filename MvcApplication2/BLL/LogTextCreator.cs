using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.BLL
{
    public class LogTextCreator
    {
        public string PrepareHttpRequest(HttpRequestBase request)
        {
            string text = "";
            text += Environment.NewLine;
            text += string.Format("Time : {0}," + Environment.NewLine, DateTime.UtcNow);
            text += string.Format("Url : {0}," + Environment.NewLine, request.Url);
            text += string.Format("Headers : {0}," + Environment.NewLine, request.Headers);
            text += string.Format("Method : {0}," + Environment.NewLine, request.HttpMethod);
            text += string.Format("Browser : {0}," + Environment.NewLine, request.Browser);
            return text;
        }
        public string PrepareHttpResponse(HttpResponseBase response)
        {
            string text = "";
            text += Environment.NewLine;
            text += string.Format("Time : {0}," + Environment.NewLine, DateTime.UtcNow);
            text += string.Format("Status : {0}," + Environment.NewLine, response.Status);
            text += string.Format("Status Code : {0}," + Environment.NewLine, response.StatusCode);
            return text;
        }
    }
}