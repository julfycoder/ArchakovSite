using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArchakovPictureSite.Helper
{
    public class AttributesIterator
    {
        Dictionary<string, string> attributesDictionary = new Dictionary<string, string>();
        public AttributesIterator(params HtmlAttribute[] attributes)
        {
            foreach (HtmlAttribute attribute in attributes)
            { attributesDictionary.Add(attribute.Name, attribute.Value); }
        }
        public void Add(params HtmlAttribute[] attributes)
        {
            foreach (HtmlAttribute attribute in attributes)
            { attributesDictionary.Add(attribute.Name, attribute.Value); }
        }
        public Dictionary<string, string> GetAttributesDictionary()
        { return attributesDictionary; }
    }
}