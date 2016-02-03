using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArchakovPictureSite.Helper
{
    public class HtmlAttribute
    {
        public HtmlAttribute(string name, string value)
        { Name = name; Value = value; }
        public string Name { get; private set; }
        public string Value { get; private set; }
    }
}