using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace MvcApplication2.BLL
{
    public class Logger
    {
        private string _path = "D:\\hometasks\\ActionFilters\\MvcApplication2\\Logs\\";

        public void Write(string text)
        {
            var name = _path + DateTime.Today.ToString("yyyy/MM/dd") + ".txt";
            var fileExists = File.Exists(name);

            using (var writer = new StreamWriter(name, fileExists))
            {
                writer.WriteLine();
                writer.WriteLine(text);
            }

        }
    }
}