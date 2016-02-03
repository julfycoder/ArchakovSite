using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ArchakovPictureSite.Helper
{
    public static class SiteElements
    {
        public static MvcHtmlString OpenPicturesFromPhotoesButton(this HtmlHelper helper, string text, string onclick, string mark)
        {
            TagBuilder NB = TagCreator.CreateTag("div", text, new HtmlAttribute("class", "NavigateButtonPost"), new HtmlAttribute("onclick", onclick));
            TagBuilder A = TagCreator.CreateTag("a", NB, new HtmlAttribute("href", mark));
            TagBuilder NBC = TagCreator.CreateTag("div", A, new HtmlAttribute("class", "NavigateButtonContainerPost"));
            return new MvcHtmlString(NBC.ToString());
        }
        public static MvcHtmlString AppendPicturesFromPhotoesButton(this HtmlHelper helper, string text, string onclick)
        {
            TagBuilder NB = TagCreator.CreateTag("div", text, new HtmlAttribute("class", "NavigateButtonPost"), new HtmlAttribute("onclick", onclick));
            TagBuilder A = TagCreator.CreateTag("a", NB);
            TagBuilder NBC = TagCreator.CreateTag("div", A, new HtmlAttribute("class", "NavigateButtonContainerPost"));
            return new MvcHtmlString(NBC.ToString());
        }
        public static MvcHtmlString ContactTheArtistButton(this HtmlHelper helper, string text, string onclick, string mark)
        {
            TagBuilder NB = TagCreator.CreateTag("div", text, new HtmlAttribute("class", "NavigateButtonPost"), new HtmlAttribute("onclick", onclick));
            TagBuilder A = TagCreator.CreateTag("a", NB, new HtmlAttribute("href", mark));
            TagBuilder NBC = TagCreator.CreateTag("div", A, new HtmlAttribute("class", "NavigateButtonContainerPost"));
            return new MvcHtmlString(NBC.ToString());
        }
        public static MvcHtmlString Breakes(this HtmlHelper helper, int num)
        {
            string breakes = "";
            for (int i = 0; i < num; i++) breakes += "<br />";
            return new MvcHtmlString(breakes);
        }
        public static MvcHtmlString Notice(this HtmlHelper helper, string message)
        {
            return new MvcHtmlString(TagCreator.CreateTag("div", message).ToString());
        }
    }
}