using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTMLDispatcher
{
    public class ElementBuilder
    {
        private string elementName;
        private string contentText;
        private Dictionary<string,string> attribute;

        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
            this.ContentText = contentText;
            this.Attribute = new Dictionary<string,string>();
        }

        public void AddAttribute(string attribute, string tagValue)
        {
            Attribute.Add(attribute,tagValue);
        }

        public void AddContent(string textContent)
        {
            this.contentText += textContent;
        }
        
        public string ElementName 
        {
            get { return this.elementName;}
            set { this.elementName = value;} 
        }

        public string ContentText 
        {
            get { return this.contentText;}
            set { this.contentText = value;} 
        }

        public Dictionary<string, string> Attribute
        {
            get
            { 
                return this.attribute; 
            }
            set
            {
                this.attribute = value;
            }
        }

        public static string operator *(ElementBuilder element, int count)
        {

            StringBuilder elements = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                elements.Append(element);
            }
            return elements.ToString();
        } 

        public override string ToString()
        {
            StringBuilder element = new StringBuilder();

            element.AppendFormat("<{0}", this.elementName);

            for (int i = 0; i < this.attribute.Count; i++)
            {
                element.AppendFormat(" {0} = \"{1}\"", this.attribute.ElementAt(i).Key,
                    this.attribute.ElementAt(i).Value);
            }
            element.AppendFormat(">{0}</{1}>", this.contentText, this.elementName);
            return element.ToString();
        }
    }

}
