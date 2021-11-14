using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTracking.Web.TagHelpers
{
    [HtmlTargetElement("adem")]
    public class Paragraf:TagHelper
    {
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //string data 
            //tagbuilder
            //stringbuilder


            //output
            //<p> <b>Adem Tunçalın</b> </p>
            var tagBuilder = new TagBuilder("p");
            tagBuilder.InnerHtml.AppendHtml("<b>Adem Tunçalın</b>");
            output.Content.SetHtmlContent(tagBuilder);
            base.Process(context, output);
        }
    }
}
