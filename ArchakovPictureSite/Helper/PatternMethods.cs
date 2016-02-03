using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArchakovPictureSite.Helper
{
    public static class PatternMethods
    {
        public static TagBuilder CreateTag(string tagName, string innerText, string innerHtml, params HtmlAttribute[] attributes)
        {
            TagBuilder tag = new TagBuilder(tagName);
            tag.MergeAttributes(new AttributesIterator(attributes).GetAttributesDictionary());
            tag.SetInnerText(innerText);
            if (innerHtml != null) tag.InnerHtml += innerHtml;
            return tag;
        }
    }
}