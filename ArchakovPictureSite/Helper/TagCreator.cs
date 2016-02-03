using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArchakovPictureSite.Helper
{
    public class TagCreator
    {
        static TagBuilder _tag;
        public static TagBuilder CreateTag(string tagName)
        {
            return new TagBuilder(tagName);
        }
        public static TagBuilder CreateTag(string tagName, params HtmlAttribute[] attributes)
        {
            SetAttributes(attributes);
            return new TagBuilder(tagName);
        }
        public static TagBuilder CreateTag(string tagName, string innerText)
        {
            _tag = new TagBuilder(tagName);
            SetInnerText(innerText);
            return _tag;
        }
        public static TagBuilder CreateTag(string tagName, string innerText, params HtmlAttribute[] attributes)
        {
            _tag = new TagBuilder(tagName);
            SetAttributes(attributes);
            SetInnerText(innerText);
            return _tag;
        }
        public static TagBuilder CreateTag(string tagName, TagBuilder innerHtml)
        {
            _tag = new TagBuilder(tagName);
            SetInnerHtml(innerHtml.ToString());
            return _tag;
        }
        public static TagBuilder CreateTag(string tagName, TagBuilder innerHtml, params HtmlAttribute[] attributes)
        {
            _tag = new TagBuilder(tagName);
            SetAttributes(attributes);
            SetInnerHtml(innerHtml.ToString());
            return _tag;
        }
        public static TagBuilder CreateTag(string tagName, string innerText, TagBuilder innerHtml)
        {
            _tag = new TagBuilder(tagName);
            SetInnerText(innerText);
            SetInnerHtml(innerHtml.ToString());
            return _tag;
        }
        public static TagBuilder CreateTag(string tagName, string innerText, TagBuilder innerHtml, params HtmlAttribute[] attributes)
        {
            _tag = new TagBuilder(tagName);
            SetAttributes(attributes);
            SetInnerText(innerText);
            SetInnerHtml(innerHtml.ToString());
            return _tag;
        }
        static void SetInnerText(string innerText)
        {
            _tag.SetInnerText(innerText);
        }
        static void SetInnerHtml(string innerHtml)
        {
            _tag.InnerHtml = innerHtml;
        }
        static void SetAttributes(params HtmlAttribute[] attributes)
        {
            _tag.MergeAttributes(new AttributesIterator(attributes).GetAttributesDictionary());
        }
    }
}