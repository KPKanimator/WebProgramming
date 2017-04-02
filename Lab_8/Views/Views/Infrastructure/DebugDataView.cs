using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;

namespace Views.Infrastructure
{
    public class DebugDataView : IView
    {
        public void Render(ViewContext viewContext, TextWriter writer)
        {
            Write(writer, "---Данные маршрутизации---");
            foreach (string key in viewContext.RouteData.Values.Keys)
            {
                Write(writer, "Ключ: {0}, Значение: {1}",
                    key, viewContext.RouteData.Values[key]);
            }

            Write(writer, "---Данные представления---");
            foreach (string key in viewContext.ViewData.Keys)
            {
                Write(writer, "Ключ: {0}, Значение: {1}", key,
                    viewContext.ViewData[key]);
            }
        }

        private void Write(TextWriter writer, string template, params object[] values)
        {
            writer.Write(string.Format(template, values) + "<p/>");
        }
    }
}