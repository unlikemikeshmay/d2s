using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace bulkybook.TagHelpers
{
    [HtmlTargetElement("classParser")]
    public class CharacterClassParser : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var childContent =  output.GetChildContentAsync().Result;
            var content = childContent.GetContent();
            switch (Convert.ToInt32(content))
            {
                case 0:
                output.Content.SetContent("Titan");
                break;
                case 1:
                output.Content.SetContent("Hunter");
                break;
                case 2:
                output.Content.SetContent("Warlock");
                break;
                default:
                output.Content.SetContent("Unknown");
                break;
            }
        }
    }
}