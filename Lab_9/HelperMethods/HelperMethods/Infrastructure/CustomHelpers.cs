using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HelperMethods.Infrastructure
{
    public static class CustomHelpers
    {
        public static MvcHtmlString ListArrayStringItems(this HtmlHelper html, string[] list)
        {
            TagBuilder tag = new TagBuilder("ul");

            foreach (string str in list)
            {
                TagBuilder itemTag = new TagBuilder("li");
                itemTag.SetInnerText(str);
                tag.InnerHtml += itemTag.ToString();
            }

            return new MvcHtmlString(tag.ToString());
        }
        public static MvcHtmlString DisplayMessage(this HtmlHelper html, string msg)
        {
            string encodedMessage = html.Encode(msg);
            string result = String.Format("Сообщение: <p>{0}</p>", encodedMessage);
            return new MvcHtmlString(result);
        }
    }
}