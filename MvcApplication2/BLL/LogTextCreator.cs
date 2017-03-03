using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using log4net;

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
            text += string.Format("ApplicationPath : {0},", Environment.NewLine + request.ApplicationPath);
            text += string.Format("CurrentExecutionFilePath : {0},", Environment.NewLine + request.CurrentExecutionFilePath);
            return text;
        }
        public string PrepareHttpRequest(HttpRequest request)
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

        public string PrepareHttpResponse(HttpResponse response)
        {
            string text = "";
            text += Environment.NewLine;
            text += string.Format("Time : {0}," + Environment.NewLine, DateTime.UtcNow);
            text += string.Format("Status : {0}," + Environment.NewLine, response.Status);
            text += string.Format("Status Code : {0}," + Environment.NewLine, response.StatusCode);
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