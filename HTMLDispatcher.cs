using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher
{
    public static class HTMLDispatcher
    {
        public string CreateImage(string imageSource,string alt, string title)
        {
            ElementBuilder image = new ElementBuilder("img");
            image.AddAttribute("src", imageSource);
            image.AddAttribute("alt", alt);
            image.AddAttribute("title", title);
            return image.ToString();
        }

        public string CreateURL(string url, string title, string text)
        {
            ElementBuilder image = new ElementBuilder("URL");
            image.AddAttribute("href", url);
            image.AddAttribute("title", title);
            image.AddAttribute("text", text);
            return image.ToString();
        }

        public string CreateInput(string inputType, string name, string value)
        {
            ElementBuilder image = new ElementBuilder("input");
            image.AddAttribute("input", inputType);
            image.AddAttribute("name", name);
            image.AddAttribute("value", value);
            return image.ToString();
        }
    }
}
